using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_
{
    public partial class Form1A : Form
    {
        public Form1A()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1A_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno) 
                {    //cevap1
                    case 1:
                        if(textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString(); 
                            textBox1.Clear();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }

                        break;

                    //cevap2
                    case 2: 
                        if(textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button2.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    //cevap3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    //cevap4
                    case 4:
                        if(textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button4.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    //cevap6
                    case 5:
                        if(textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button5.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                    //Cevap6
                    case 6:
                        if(textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button6.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                     //cevap7
                     case 7:
                        if(textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button7.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                      //cevap8
                      case 8:
                        if(textBox1.Text == "hal")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;    
                            label2.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button8.BackColor= Color.Red;
                            yanlis++;   
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                      //cevap9
                      case 9:
                        if(textBox1.Text == "ısparta")
                        {
                            button9.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button9.BackColor= Color.Red;
                            yanlis++;   
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                      //cevap10
                      case 10:
                        if(textBox1.Text == "içel")
                        {
                            button10.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button10.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();

                        }
                        break;
                        //cevap11
                      case 11:
                        if(textBox1.Text == "jandarma")
                        {
                            button11.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button11.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap12
                      case 12:
                        if(textBox1.Text == "kayısı")
                        {
                            button12.BackColor= Color.Green;
                            dogru++;    
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button12.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;  
                        //cevap13
                      case 13:
                        if(textBox1.Text == "lale")
                        {
                            button13.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button13.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;  
                       //cevap14
                      case 14:
                        if (textBox1.Text == "mart")
                        {
                            button16.BackColor= Color.Green;    
                            dogru++;    
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button16.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;  
                       //cevap15
                      case 15:
                        if(textBox1.Text == "ney")
                        {
                            button15.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button15.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                       //cevap16
                      case 16:
                        if(textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button16.BackColor= Color.Red;
                            yanlis++;   
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                       //Cevap17
                      case 17:
                        if(textBox1.Text == "pırasa")
                        {
                            button17.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                       //cevap18
                       case 18:
                        if(textBox1.Text == "ramazan")
                        {
                            button18.BackColor= Color.Green;    
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button18.BackColor= Color.Red;  
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap19
                       case 19:
                        if(textBox1.Text == "snake")
                        {
                            button19.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap20
                      case 20:
                        if(textBox1.Text =="tarkan")
                        {
                            button20.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button20.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap21
                      case 21:
                        if(textBox1.Text == "umut")
                        {
                            button21.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button21.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap22
                       case 22:
                        if(textBox1.Text == "van")
                        {
                            button22.BackColor= Color.Green;
                            dogru++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap23
                       case 23:
                        if(textBox1.Text == "yıldırım")
                        {
                            button23.BackColor= Color.Green;
                            dogru ++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();
                        }
                        else
                        {
                            button23.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;
                        //cevap23
                       case 24:
                        if(textBox1.Text == "zeytin")
                        {
                            button24.BackColor= Color.Green;
                            dogru ++;
                            label2.Text=dogru.ToString();
                            textBox1.Clear();

                        }
                        else
                        {
                            button24.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                            textBox1.Clear();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text=soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
               
            }
            if(soruno==2) 
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;  
            }
            if(soruno==3) 
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if(soruno==4) 
            {
                richTextBox1.Text = "Karpuzuyla Ünlü İlimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5) 
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
                button5.BackColor = Color.Yellow;
            }
            if(soruno==6) 
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if(soruno == 7) 
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
;            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne?";
                button8.BackColor = Color.Yellow;
            }
            if(soruno==9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın Meşhur Meyvesi?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı ?";
                button14.BackColor = Color.Yellow;
            }
            if(soruno== 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti?";
                button15.BackColor = Color.Yellow;
            }
            if(soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevilmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                button17.BackColor = Color.Yellow;  
            }
            if (soruno == 18)
            {
                richTextBox1.Text= "11 ayın sultanı?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizce yılan?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiye'nin mega starı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısıyla ünlü ilimiz?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button23.BackColor = Color.Yellow;
            }
            if(soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                button24.BackColor = Color.Yellow;
            }



        }
        
    }
}
