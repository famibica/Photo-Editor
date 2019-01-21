using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ImageProcessing;

namespace EditorPhoto
{
    public partial class Form1 : Form
    {
        //Forms
        private Form2 histogram;
        private Form2 hist_equ;

        // Variáveis
        private int[] histograma_R = new int[256];
        private int[] histograma_G = new int[256];
        private int[] histograma_B = new int[256];
        private bool luminancia;
        private int numTons = 256;
        private Bitmap imgFinal;

        // Kernels - Lista de Kernels - Filtros
        private double[,] gaussiano = { { 0.0625, 0.125, 0.0625 }, { 0.125, 0.25, 0.125 }, { 0.0625, 0.125, 0.0625 } };
        private double[,] laplaciano = { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        private double[,] passaAltas = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
        private double[,] prewittHx = { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
        private double[,] prewittHyHx = { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
        private double[,] sobelHx = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        private double[,] sobelHy = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

        private bool verifica_grayscale(Bitmap image) //verifica se está em escala de cinza
        {
            Color pixel;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    pixel = image.GetPixel(i, j);
                    if (pixel.R != pixel.G && pixel.G != pixel.B)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private Bitmap NegativarImagem(Bitmap image)
        {
            //seta configurações da barra de progresso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = image.Width * image.Height;
            progressBar1.Value = 0;

            //cria bitmap da imagem nova com as mesmas dimensoes da imagem original
            Bitmap imagem_negada = new Bitmap(image.Width, image.Height);

            //Cria Colors para cada Cor da imagem negada e a imagem original
            Color CorNegada, CorImage;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    CorImage = image.GetPixel(i, j);
                    //aplica 255 - a cor atual
                    CorNegada = Color.FromArgb(255 - CorImage.R, 255 - CorImage.G, 255 - CorImage.B);
                    //seta no pixel
                    imagem_negada.SetPixel(i, j, CorNegada);
                    //soma 1 na barra de progresso
                    progressBar1.Value++;
                }
            }
            //zera barra de progresso no final
            progressBar1.Value = 0;
            //retorna imagem negada
            return imagem_negada;
        }

        // Funções de manipulação de imagens
        private Bitmap Brilho_Contraste(Bitmap image, float a, int brilho)
        {
            int r, g, b;

            Color BrilhoFeito;

            //configuração da barra de progresso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = image.Width * image.Height;
            progressBar1.Value = 0; 

            for (int i = 0; i < image.Width; i++) 
            {
                for (int j = 0; j < image.Height; j++)
                {
                    r = (int)(a * image.GetPixel(i, j).R + brilho); //soma o valor do brilho ao pixel
                    g = (int)(a * image.GetPixel(i, j).G + brilho); //soma o valor do brilho ao pixel
                    b = (int)(a * image.GetPixel(i, j).B + brilho); //soma o valor do brilho ao pixel

                    if (r > 255) r = 255; //verifica se o brilho de R é maior que 255 ou menor que 0, caso seja ele aplica o limite máximo de 255 e 0
                    else if (r < 0) r = 0;
                    if (g > 255) g = 255; //verifica se o brilho de G é maior que 255 ou menor que 0, caso seja ele aplica o limite máximo de 255 e 0
                    else if (g < 0) g = 0;
                    if (b > 255) b = 255; //verifica se o brilho de B é maior que 255 ou menor que 0, caso seja ele aplica o limite máximo de 255 e 0
                    else if (b < 0) b = 0;

                    BrilhoFeito = Color.FromArgb(r, g, b);
                    image.SetPixel(i, j, BrilhoFeito); //seta o pixel com novo brilho
                    progressBar1.Value++; //adiciona 1 a barra de progresso
                }
            }
            progressBar1.Value = 0;
            return image;
        }
       
        public Bitmap GrayScale(Bitmap original, float factorR, float factorG, float factorB, bool quantize)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = original.Width * original.Height;
            progressBar1.Value = 0;
            Bitmap novo = new Bitmap(original.Width, original.Height);
            Color CorEmEscalaDeCinza, originalColor;
            int grayScale, r, g, b;
            //numTons = numTons/(int)numericUpDown1.Value;
            //MessageBox.Show("Width = " + original.Width + " - Height = " + original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    originalColor = original.GetPixel(i, j);
                    if (quantize)
                    {
                        r = (int)Math.Floor((originalColor.R * factorR) / numTons);
                        g = (int)Math.Floor((originalColor.G * factorG) / numTons);
                        b = (int)Math.Floor((originalColor.B * factorB) / numTons);
                        r = (int)(r * numTons / factorR);
                        g = (int)(g * numTons / factorG);
                        b = (int)(b * numTons / factorR);
                        CorEmEscalaDeCinza = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        grayScale = (int)((originalColor.R * factorR) + (originalColor.G * factorG) + (originalColor.B * factorB));
                        CorEmEscalaDeCinza = Color.FromArgb(grayScale, grayScale, grayScale);
                    }
                    novo.SetPixel(i, j, CorEmEscalaDeCinza);
                    progressBar1.Value++;
                }
            }
            progressBar1.Value = 0;
            imgFinal = novo;
            return novo;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox5.Image;
            imgFinal = (Bitmap)pictureBox6.Image;
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox5.Image = new Bitmap(open.FileName);
                imgFinal = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap imagem_flip_horizontal = (Bitmap)pictureBox6.Image;
            int width = imagem_flip_horizontal.Width;
            int height = imagem_flip_horizontal.Height;

            Bitmap imagem_flip_horizontal_terminado = new Bitmap(imagem_flip_horizontal.Width, imagem_flip_horizontal.Height);

            int i, u;
            for (i = 0; i < height; i++)
            {
                for (u = 0; u < width; u++)
                {
                    imagem_flip_horizontal_terminado.SetPixel(width - u - 1, i, imagem_flip_horizontal.GetPixel(u, i));
                }
            }
            pictureBox6.Image = imagem_flip_horizontal_terminado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap imagem_flip_vertical = (Bitmap)pictureBox6.Image;
            int width = imagem_flip_vertical.Width;
            int height = imagem_flip_vertical.Height;

            Bitmap imagem_flip_vertical_terminado = new Bitmap(imagem_flip_vertical.Width, imagem_flip_vertical.Height);

            int i, u;
            for (u = 0; u < width; u++)
            {
                for (i = 0; i < height; i++)
                {
                    imagem_flip_vertical_terminado.SetPixel(u, height -i -1, imagem_flip_vertical.GetPixel(u, i));
                }
            }
            pictureBox6.Image = imagem_flip_vertical_terminado;
        }

        private int[] Histogram(Bitmap image, bool exibe)
        {
            luminancia = !(verifica_grayscale(new Bitmap(pictureBox6.Image)));
            int[] histograma = new int[256];
            int indice;
            for (int k = 0; k < 256; k++)
            {
                histograma[k] = 0;
                histograma_R[k] = 0;
                histograma_G[k] = 0;
                histograma_B[k] = 0;
            }
            if (progressBar1.Value == 0)
            {
                progressBar1.Minimum = 0;
                if (progressBar1.Maximum < (image.Width * image.Height + 256))
                {
                    progressBar1.Maximum = (image.Width * image.Height) + 256;
                }
            }
            if (luminancia)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        indice = (int)Math.Floor((image.GetPixel(i, j).R * 0.299) + (image.GetPixel(i, j).G * 0.587) + (image.GetPixel(i, j).B * 0.114));
                        histograma[indice]++;
                        progressBar1.Value++;
                        histograma_R[image.GetPixel(i, j).R]++;
                        histograma_G[image.GetPixel(i, j).G]++;
                        histograma_B[image.GetPixel(i, j).B]++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        histograma[image.GetPixel(i, j).R]++;
                        progressBar1.Value++;
                    }
                }
            }
            if (exibe)
            {
                histogram = new Form2();
                if (luminancia)
                {
                    histogram.chart_histograma.Series[0].Name = "Nº de Pixels Vermelhos";
                    histogram.chart_histograma.Series[1].Name = "Nº de Pixels Verdes";
                    histogram.chart_histograma.Series[2].Name = "Nº de Pixels Azuis";
                    for (int i = 0; i < 256; i++)
                    {
                        histogram.chart_histograma.Series[0].Points.InsertY(i, histograma_R[i]);
                        histogram.chart_histograma.Series[1].Points.InsertY(i, histograma_G[i]);
                        histogram.chart_histograma.Series[2].Points.InsertY(i, histograma_B[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < 256; i++)
                    {
                        histogram.chart_histograma.Series[0].Points.InsertY(i, histograma[i]);
                        progressBar1.Value++;
                    }
                    histogram.Text = "Histograma Da Imagem Escala de Cinza";
                }
                histogram.SetDesktopLocation(540, 175);
                histogram.Show();
                //exibindo_histogram = true;
                progressBar1.Value = 0;
            }
            return histograma;
        }

        private void Histogram_Equalize(Bitmap image)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = (((image.Width * image.Height) + 256) * 5);
            progressBar1.Value = 0;
            int[] histogram = Histogram(image, false);
            int[] histogram_cumulative = new int[histogram.GetLength(0)];
            Form2 hist = new Form2();

            if (luminancia)
            {
                hist.chart_histograma.Series[0].Name = "Nº de Pixels Tons de Vermelho";
                hist.chart_histograma.Series[1].Name = "Nº de Pixels Tons de Verde";
                hist.chart_histograma.Series[2].Name = "Nº de Pixels Tons de Azul";
                for (int i = 0; i < 256; i++)
                {
                    hist.chart_histograma.Series[0].Points.InsertY(i, histograma_R[i]);
                    hist.chart_histograma.Series[1].Points.InsertY(i, histograma_G[i]);
                    hist.chart_histograma.Series[2].Points.InsertY(i, histograma_B[i]);
                }
            }
            else
            {
                hist.chart_histograma.Series[1].IsVisibleInLegend = false;
                hist.chart_histograma.Series[2].IsVisibleInLegend = false;
                hist.chart_histograma.ChartAreas[1].Visible = false;
                hist.chart_histograma.ChartAreas[2].Visible = false;
                for (int i = 0; i < 256; i++)
                {
                    hist.chart_histograma.Series[0].Points.InsertY(i, histogram[i]);
                    //progressBar1.Value++;
                }
            }
            hist.Text = "Histograma Original";
            hist.Show();

            Color originalColor, newColor;
            int r, g, b;
            float alpha = (float)255 / (image.Width * image.Height);
            histogram_cumulative[0] = ((int)alpha) * (histogram[0]);
            for (int i = 1; i < histogram.GetLength(0); i++)
            {
                histogram_cumulative[i] = (int)Math.Round((histogram_cumulative[i - 1] + (alpha) * histogram[i]));
                progressBar1.Value++;
            }
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    originalColor = image.GetPixel(i, j);
                    r = histogram_cumulative[(int)originalColor.R];
                    g = histogram_cumulative[(int)originalColor.G];
                    b = histogram_cumulative[(int)originalColor.B];
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    if (r < 0) r = 0;
                    if (g < 0) g = 0;
                    if (b < 0) b = 0;

                    newColor = Color.FromArgb(r, g, b);
                    image.SetPixel(i, j, newColor);
                    progressBar1.Value++;
                }
            }
            pictureBox6.Image = image;
            imgFinal = image;
            hist_equ = new Form2();

            histogram = Histogram(image, false);

            if (luminancia)
            {
                hist_equ.chart_histograma.Series[0].Name = "Nº de Pixels em tons de vermelho";
                hist_equ.chart_histograma.Series[1].Name = "Nº de Pixels em tons de verde";
                hist_equ.chart_histograma.Series[2].Name = "Nº de Pixels em tons de azul";
                for (int i = 0; i < 256; i++)
                {
                    hist_equ.chart_histograma.Series[0].Points.InsertY(i, histograma_R[i]);
                    hist_equ.chart_histograma.Series[1].Points.InsertY(i, histograma_G[i]);
                    hist_equ.chart_histograma.Series[2].Points.InsertY(i, histograma_B[i]);
                }
            }
            else
            {
                for (int i = 0; i < 256; i++)
                {
                    hist_equ.chart_histograma.Series[0].Points.InsertY(i, histogram[i]);
                    progressBar1.Value++;
                }
            }
            hist_equ.SetDesktopLocation(600, 175);
            hist_equ.Show();
            progressBar1.Value = 0;
        }

        public void Conv()
        {
            double[,] k = {{(double)a.Value,(double)b.Value,(double)c.Value},
                          {(double)d.Value,(double)mid.Value,(double)f.Value},
                          {(double)g.Value,(double)h.Value,(double)i.Value}};
            Kernel kernel = new Kernel(k);
            Convolution convoluidor = new Convolution();
            pictureBox6.Image = convoluidor.Apply(pictureBox6.Image, kernel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = GrayScale(new Bitmap(pictureBox6.Image), (float)0.299, (float)0.587, (float)0.114, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int quantosTons = (int)numericUpDown1.Value;
            quantosTons--;
            float factor = quantosTons;
            pictureBox6.Image = GrayScale(new Bitmap(pictureBox6.Image), factor, factor, factor, true);
        }

        private void salvarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (pictureBox6.Image != null)
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox6.Image.Save(save.FileName);
                }
            }
        }

        private void botaoHistograma_Click(object sender, EventArgs e)
        {
            Histogram(new Bitmap(pictureBox6.Image), true);
            //Form2 newForm2 = new Form2();
            //newForm2.Show();
        }

        private void aplicaContraste_Click(object sender, EventArgs e)
        {
            float contraste_valor = (float)contraste.Value / 10;
            pictureBox6.Image = Brilho_Contraste(new Bitmap(pictureBox6.Image), contraste_valor, 0);
        }

        private void aplicaBrilho_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Brilho_Contraste(new Bitmap(pictureBox6.Image), 1, brilho.Value);
        }

        private void negativarImagem_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = NegativarImagem(new Bitmap(pictureBox6.Image));
        }

        private void botaoEqualizarHistograma_Click(object sender, EventArgs e)
        {
            Histogram_Equalize(new Bitmap(pictureBox6.Image));
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            int divisor_Width = (int)ZoomSx.Value;
            int divisor_Height = (int)ZoomSy.Value;

            Bitmap imgDiminuida = new Bitmap(imgFinal.Width / divisor_Width, imgFinal.Height / divisor_Height);

            for (int x = 0; x < imgDiminuida.Width; x++)
            {
                for (int y = 0; y < imgDiminuida.Height; y++)
                {
                    double mixRed = 0;
                    double mixGreen = 0;
                    double mixBlue = 0;

                    int box = 0;
                    for (int i = 0; i < divisor_Width; i++)
                    {
                        for (int j = 0; j < divisor_Height; j++)
                        {
                            if (x * divisor_Width + i < imgFinal.Width && y * divisor_Height + j < imgFinal.Height)
                            {
                                box++;
                                Color pixel = imgFinal.GetPixel(x * divisor_Width + i, y * divisor_Height + j);
                                mixRed += pixel.R;
                                mixGreen += pixel.G;
                                mixBlue += pixel.B;
                            }

                        }
                    }
                    mixRed = mixRed / box;
                    mixGreen = mixGreen / box;
                    mixBlue = mixBlue / box;

                    Color mean = Color.FromArgb((byte)mixRed, (byte)mixGreen, (byte)mixBlue);

                    imgDiminuida.SetPixel(x, y, mean);
                }
            }
            pictureBox6.Image = imgDiminuida;
            imgFinal = imgDiminuida;
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            int cont_Height = 0, cont_Width = 0, cont_Height2 = 0, cont_Width2 = 0;
            int mediaR = 0, mediaG = 0, mediaB = 0, mediaA = 0;

            Bitmap imagem = null;

            imagem = imgFinal;

            int width = imagem.Width;
            int height = imagem.Height;

            if ((ZoomSx.Value == 1) && (ZoomSy.Value == 1))
            {
                pictureBox6.Image = imgFinal;
            }
            else
            {
                Bitmap imgComZoom = new Bitmap((int)ZoomSx.Value * imagem.Width, (int)ZoomSy.Value * height);

                while (cont_Height < height)
                {
                    while (cont_Width < width)
                    {
                        imgComZoom.SetPixel(cont_Width2, cont_Height2, imagem.GetPixel(cont_Width, cont_Height));
                        cont_Width = cont_Width + 1;
                        cont_Width2 = cont_Width2 + 2;
                    }
                    cont_Width = 0;
                    cont_Width2 = 0;
                    cont_Height = cont_Height + 1;
                    cont_Height2 = cont_Height2 + 2;
                }
                cont_Width = 0;
                cont_Height = 0;
                while (cont_Height < 2 * height)
                {
                    while (cont_Width < 2 * imagem.Width)
                    {
                        if (cont_Width % 2 == 1)
                        {
                            if (cont_Width + 1 >= 2 * imagem.Width)
                            {
                                mediaR = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).R);
                                mediaG = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).G);
                                mediaB = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).B);
                                mediaA = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).A);
                            }
                            else
                            {
                                mediaR = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).R + imgComZoom.GetPixel(cont_Width + 1, cont_Height).R) / 2;
                                mediaG = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).G + imgComZoom.GetPixel(cont_Width + 1, cont_Height).G) / 2;
                                mediaB = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).B + imgComZoom.GetPixel(cont_Width + 1, cont_Height).B) / 2;
                                mediaA = (imgComZoom.GetPixel(cont_Width - 1, cont_Height).A + imgComZoom.GetPixel(cont_Width + 1, cont_Height).A) / 2;
                            }
                            imgComZoom.SetPixel(cont_Width, cont_Height, Color.FromArgb(mediaA, mediaR, mediaG, mediaB));
                        }
                        cont_Width = cont_Width + 1;
                    }
                    cont_Width = 0;
                    cont_Height = cont_Height + 2;
                }
                cont_Width = 0;
                cont_Height = 0;
                while (cont_Width < 2 * imagem.Width)
                {
                    while (cont_Height < 2 * height)
                    {
                        if (cont_Height % 2 == 1)
                        {
                            if (cont_Height + 1 >= 2 * height)
                            {
                                mediaR = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).R);
                                mediaG = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).G);
                                mediaB = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).B);
                                mediaA = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).A);
                            }
                            else
                            {
                                mediaR = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).R + imgComZoom.GetPixel(cont_Width, cont_Height + 1).R) / 2;
                                mediaG = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).G + imgComZoom.GetPixel(cont_Width, cont_Height + 1).G) / 2;
                                mediaB = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).B + imgComZoom.GetPixel(cont_Width, cont_Height + 1).B) / 2;
                                mediaA = (imgComZoom.GetPixel(cont_Width, cont_Height - 1).A + imgComZoom.GetPixel(cont_Width, cont_Height + 1).A) / 2;
                            }
                            imgComZoom.SetPixel(cont_Width, cont_Height, Color.FromArgb(mediaA, mediaR, mediaG, mediaB));
                        }
                        cont_Height = cont_Height + 1;
                    }
                    cont_Height = 0;
                    cont_Width = cont_Width + 1;
                }
                pictureBox6.Image = imgComZoom;
                imgFinal = imgComZoom;
            }
        }

        private List<Color> getPixels(Bitmap image, int dimX, int dimY, Point baseRet)
        {
            List<Color> pixels = new List<Color> { };
            Point limite = new Point();
            if (baseRet.X + dimX > image.Width)
            {
                limite.X = image.Width - baseRet.X;
            }
            else
            {
                limite.X = baseRet.X + dimX;
            }
            if (baseRet.Y + dimY > image.Height)
            {
                limite.Y = image.Width - baseRet.Y;
            }
            else
            {
                limite.Y = baseRet.Y + dimY;
            }
            for (int i = baseRet.X; i < limite.X; i++)
            {
                for (int j = baseRet.Y; j < limite.Y; j++)
                {
                    pixels.Add(image.GetPixel(i, j));
                }
            }
            return pixels;
        }

        private void Rotacao_Horaria_Click(object sender, EventArgs e)
        {
            Bitmap ImagemOriginal = imgFinal;
            Bitmap ImagemRotacionada = new Bitmap(ImagemOriginal.Height, ImagemOriginal.Width);

            int width_cont = 0;
            int height_cont = 0;

            while (width_cont < ImagemOriginal.Width)
            {
                while (height_cont < ImagemOriginal.Height)
                {
                    ImagemRotacionada.SetPixel(ImagemOriginal.Height - height_cont - 1, width_cont, ImagemOriginal.GetPixel(width_cont, height_cont));
                    height_cont = height_cont + 1;
                }
                height_cont = 0;
                width_cont = width_cont + 1;
            }

            imgFinal = ImagemRotacionada;
            pictureBox6.Image = ImagemRotacionada;
        }

        private void Rotacao_Anti_Horaria_Click(object sender, EventArgs e)
        {
            Bitmap ImagemOriginal = imgFinal;
            Bitmap ImagemRotacionada = new Bitmap(ImagemOriginal.Height, ImagemOriginal.Width);

            int width_cont = 0;
            int height_cont = 0;

            while (height_cont < ImagemOriginal.Height)
            {
                while (width_cont < ImagemOriginal.Width)
                {
                    ImagemRotacionada.SetPixel(height_cont, ImagemOriginal.Width - width_cont - 1, ImagemOriginal.GetPixel(width_cont, height_cont));
                    width_cont = width_cont + 1;
                }
                width_cont = 0;
                height_cont = height_cont + 1;
            }

            imgFinal = ImagemRotacionada;
            pictureBox6.Image = ImagemRotacionada;
        }

        private void showKernel(double[,] kernel, int factor)
        {
            a.Value = (Decimal)kernel[0, 0];
            b.Value = (Decimal)kernel[0, 1];
            c.Value = (Decimal)kernel[0, 2];
            d.Value = (Decimal)kernel[1, 0];
            mid.Value = (Decimal)kernel[1, 1];
            f.Value = (Decimal)kernel[1, 2];
            g.Value = (Decimal)kernel[2, 0];
            h.Value = (Decimal)kernel[2, 1];
            i.Value = (Decimal)kernel[2, 2];
        }

        private void filtro_gaussiano_Click(object sender, EventArgs e)
        {
            showKernel(gaussiano, 0);
        }

        private void filtro_laplaciano_Click(object sender, EventArgs e)
        {
            showKernel(laplaciano, 0);
        }

        private void filtro_passas_altas_generico_Click(object sender, EventArgs e)
        {
            showKernel(passaAltas, 0);
        }

        private void filtro_prewitt_hx_Click(object sender, EventArgs e)
        {
            showKernel(prewittHx, 127);
        }

        private void filtro_prewitt_hy_hx_Click(object sender, EventArgs e)
        {
            showKernel(prewittHyHx, 127);
        }

        private void filtro_sobel_hx_Click(object sender, EventArgs e)
        {
            showKernel(sobelHx, 127);
        }

        private void filtro_sobel_hy_Click(object sender, EventArgs e)
        {
            showKernel(sobelHy, 127);
        }

        private void aplicar_filtro_Click(object sender, EventArgs e)
        {
            //Conv();
            Bitmap ImagemConvolucao = new Bitmap(imgFinal.Width, imgFinal.Height);

            for (int cont_w = 1; cont_w < imgFinal.Width - 1; cont_w++)
             {
                 for (int cont_h = 1; cont_h < imgFinal.Height - 1; cont_h++)
                {

                    double aImagem = imgFinal.GetPixel(cont_w - 1, cont_h - 1).R;
                    double bImagem = imgFinal.GetPixel(cont_w - 1, cont_h).R;
                    double cImagem = imgFinal.GetPixel(cont_w - 1, cont_h + 1).R;
                    double dImagem = imgFinal.GetPixel(cont_w, cont_h - 1).R;
                    double midImagem = imgFinal.GetPixel(cont_w, cont_h).R;
                    double fImagem = imgFinal.GetPixel(cont_w, cont_h + 1).R;
                    double gImagem = imgFinal.GetPixel(cont_w + 1, cont_h - 1).R;
                    double hImagem = imgFinal.GetPixel(cont_w + 1, cont_h).R;
                    double iImagem = imgFinal.GetPixel(cont_w + 1, cont_h + 1).R;

                    double Convolucao = (aImagem * (double)i.Value) + (bImagem * (double)h.Value) + (cImagem * (double)g.Value) + (dImagem * (double)f.Value) + (midImagem * (double)mid.Value) + (fImagem * (double)d.Value) + (gImagem * (double)c.Value) + (hImagem * (double)b.Value) + (iImagem * (double)a.Value);

                    if (Checkbox_127.Checked) 
                    {
                        Convolucao += 127;
                    }

                    if (Convolucao > 255) Convolucao = 255;
                    if (Convolucao < 0) Convolucao = 0;

                    Color ValorPixelFinal = Color.FromArgb((byte)Convolucao, (byte)Convolucao, (byte)Convolucao);

                    ImagemConvolucao.SetPixel(cont_w, cont_h, ValorPixelFinal);
                }
            }

            imgFinal = ImagemConvolucao;
            pictureBox6.Image = imgFinal;
      }
    }
}
