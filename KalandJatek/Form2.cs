﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KalandJatek
{
    class PlayerStats
    {
        public int Skill { get; set; }
        public int Stamina { get; set; }
        public int Luck { get; set; }
        public int Hp { get; set; }
        public int Coins { get; set; }

        private Random rand = new Random();

        public PlayerStats()
        {
            Skill = rand.Next(1, 7) + 6;
            Stamina = (rand.Next(1, 7) + rand.Next(1, 7)) + 12;
            Luck = rand.Next(1, 7) + 6;
            Hp = rand.Next(1, 7) + 6;
            Coins = 20;
        }
    }
    public partial class Form2 : Form
    {
        private PictureBox potionselect;
        private PictureBox Player;
        private PictureBox Enemy;
        private Button eletero;
        private Button szerencse;
        private Button ugyesseg;
        private Button tovabb;
        private Button tovabb2;
        private Button tovabb3;
        private Button tovabb4;
        private Button tovabb5;
        private Button tovabb6;
        private Button tovabb7;
        private Button tovabb8;
        private Button tovabb9;
        private Button tovabb10;
        private Button tovabb11;
        private Button tovabb12;
        private Button tovabb13;
        private Button tovabb14;
        private Button Exit;
        private Label italok;
        private Label hp;
        private Label stamina;
        private Label luck;
        private Label enemyhp;
        private Label playerhp;
        private Label Coins;
        private Label felszereles;
        private Label felszereles2;
        private Label elelmiszer;
        private Label ekkovek;
        private Label Nyeremeny;
        private List<string> invlist = new List<string>();
        private List<Label> SzovegList = new List<Label>();
        private List<Button> SzamGombListegesz = new List<Button>();
        private PlayerStats playerStats = new PlayerStats();
        private int currentIndex = 0;

        public Form2()
        {
            Form2_Load(sender: null, e: null);

            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Icon = new Icon("favicon.ico");
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            Image myimage = new Bitmap("bg.png");
            this.BackgroundImage = myimage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Exit = new Button
            {
                Text = "KILÉPÉS",
                Size = new Size(150, 100),
                Location = new Point(1750, 850),
                Font = new Font("Courier New", 20, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup
            };
            Exit.Click += exit_Click;
            Controls.Add(Exit);

            eletero = new Button
            {
                Text = "Kiválasztás",
                Size = new Size(140, 75),
                Location = new Point(810, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup
            };
            eletero.Click += First_Click;
            Controls.Add(eletero);

            szerencse = new Button
            {
                Text = "Kiválasztás",
                Size = new Size(150, 75),
                Location = new Point(975, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup
            };
            szerencse.Click += Second_Click;
            Controls.Add(szerencse);

            ugyesseg = new Button
            {
                Text = "Kiválasztás",
                Size = new Size(140, 75),
                Location = new Point(1150, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup
            };
            ugyesseg.Click += Third_Click;
            Controls.Add(ugyesseg);

            italok = new Label
            {
                Text = "Italok:",
                Size = new Size(160, 140),
                Location = new Point(50, 850),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(italok);

            hp = new Label
            {
                Text = $"HP: {playerStats.Hp}\n",
                Size = new Size(160, 160),
                Location = new Point(50, 50),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(hp);

            felszereles = new Label
            {
                Text = $"Felszerelés:\n",
                Size = new Size(200, 200),
                Location = new Point(50, 250),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(felszereles);

            felszereles2 = new Label
            {
                Size = new Size(180,200),
                Location = new Point(250, 250),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(felszereles2);

            stamina = new Label
            {
                Text = $"Stamina: {playerStats.Stamina}\n",
                Size = new Size(160, 160),
                Location = new Point(220, 50),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(stamina);
            
            luck = new Label
            {
                Text = $"Luck: {playerStats.Luck}\n",
                Size = new Size(160, 160),
                Location = new Point(390, 50),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(luck);

            Coins = new Label
            {
                Text = $"Coins: {playerStats.Coins}\n",
                Size = new Size(160, 160),
                Location = new Point(550, 50),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(Coins);

            Nyeremeny = new Label
            {
                Size = new Size(350, 50),
                Location = new Point(800,250),
                Font = new Font("Courier New", 16, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#0c0b0d"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            Controls.Add(Nyeremeny);

            elelmiszer = new Label()
            {
                Text = $"Élelmiszer:\n",
                Size = new Size(160, 160),
                Location = new Point(50, 450),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(elelmiszer);
            
            ekkovek = new Label()
            {
                Text = $"Ékkövek:\n",
                Size = new Size(160, 160),
                Location = new Point(50, 650),
                Font = new Font("Courier New", 16),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            Controls.Add(ekkovek);

            tovabb2 = new Button
            {
                Text = "87",
                Size = new Size(150, 75),
                Location = new Point(750, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb2.Click += Tovabb2_Click;
            Controls.Add(tovabb2);

            tovabb3 = new Button
            {
                Text = "6",
                Size = new Size(150, 75),
                Location = new Point(900, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb3.Click += Tovabb3_Click;
            Controls.Add(tovabb3);
            
            tovabb4 = new Button
            {
                Text = "111",
                Size = new Size(150, 75),
                Location = new Point(1050, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb4.Click += Tovabb4_Click;
            Controls.Add(tovabb4);
            
            tovabb5 = new Button
            {
                Text = "53",
                Size = new Size(150, 75),
                Location = new Point(1200, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb5.Click += Tovabb5_Click;
            Controls.Add(tovabb5);
            
            tovabb6 = new Button
            {
                Text = "163",
                Size = new Size(150, 75),
                Location = new Point(750, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb6.Click += Tovabb6_Click;
            Controls.Add(tovabb6);
            
            tovabb7 = new Button
            {
                Text = "185",
                Size = new Size(150, 75),
                Location = new Point(970, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb7.Click += Tovabb7_Click;
            Controls.Add(tovabb7);
            
            tovabb8 = new Button
            {
                Text = "168",
                Size = new Size(150, 75),
                Location = new Point(1200, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb8.Click += Tovabb8_Click;
            Controls.Add(tovabb8);
            
            tovabb9 = new Button
            {
                Text = "181",
                Size = new Size(150, 75),
                Location = new Point(750, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb9.Click += Tovabb9_Click;
            Controls.Add(tovabb9);
            
            tovabb10 = new Button
            {
                Text = "193",
                Size = new Size(150, 75),
                Location = new Point(970, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb10.Click += Tovabb10_Click;
            Controls.Add(tovabb10);
            
            tovabb11 = new Button
            {
                Text = "171",
                Size = new Size(150, 75),
                Location = new Point(1200, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb11.Click += Tovabb11_Click;
            Controls.Add(tovabb11);

            tovabb12 = new Button
            {
                Text = "91",
                Size = new Size(150, 75),
                Location = new Point(750, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb12.Click += Tovabb12_Click;
            Controls.Add(tovabb12);

            tovabb13 = new Button
            {
                Text = "131",
                Size = new Size(150, 75),
                Location = new Point(970, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb13.Click += Tovabb13_Click;
            Controls.Add(tovabb13);

            tovabb14 = new Button
            {
                Text = "77",
                Size = new Size(150, 75),
                Location = new Point(1200, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb14.Click += Tovabb14_Click;
            Controls.Add(tovabb14);

            tovabb = new Button
            {
                Text = "Tovább",
                Size = new Size(600, 75),
                Location = new Point(750, 850),
                Font = new Font("Courier New", 12, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#a17e51"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Visible = false
            };
            tovabb.Click += Tovabb_Click;
            Controls.Add(tovabb);


            for (int i = 0; i < 200; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(600, 75);
                btn.Text = i.ToString();
                btn.Location = new Point(750, 850);
                btn.Font = new Font("Courier New", 12, FontStyle.Bold);
                btn.BackColor = ColorTranslator.FromHtml("#a17e51");
                btn.ForeColor = Color.White;
                btn.Visible = false;
                SzamGombListegesz.Add(btn);
                Controls.Add(btn);
            }

            for (int i = 0; i < 200; i++)
            {
                Label lbl = new Label();
                lbl.Size = new Size(600, 300);
                lbl.Text = "#1\nBelöknek a lenti alagútba, és rád zárják az ajtót, kizárva ezzel a nyíláson át beszűrődő természetes világosságot. Innentől kezdve kizárólag a falra rögzített fáklyáktól remélhetsz valamennyi fényt. Ahogy szemed hozzászokik a homályhoz, látod, hogy az alagút észak felé indul. Nagyot sóhajtasz a dolog igazságtalansága felett, majd elindulsz abba az irányba. Lapozz a 41-re.";
                lbl.Location = new Point(750, 550);
                lbl.Font = new Font("Courier New", 12.7f, FontStyle.Bold);
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.White;
                lbl.Visible = false;
                SzovegList.Add(lbl);
                Controls.Add(lbl);
            }

            potionselect = new PictureBox()
            {
                Image = Image.FromFile("Italvalasztas.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(800, 400),
                Location = new Point(650, 550)
            };
            Controls.Add(potionselect);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void First_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jó választás utazó!\n" + "Választásod: Életerő ital!", "Sikeres választás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invlist.Add("Életerő ital");
            potionselect.Visible = false;
            eletero.Visible = false;
            szerencse.Visible = false;
            ugyesseg.Visible = false;
            SzovegList[0].Visible = true;
            tovabb.Visible = true;
            italok.Visible = true;
            Image myimage = new Bitmap("hp.png");
            italok.Image = myimage;
            italok.ImageAlign = ContentAlignment.TopLeft;
            hp.Visible = true;
            Image hpstat = new Bitmap("hpstat.png");
            hp.Image = hpstat;
            hp.ImageAlign = ContentAlignment.MiddleLeft;
            stamina.Visible = true;
            Image staminastat = new Bitmap("staminastat.png");
            stamina.Image = staminastat;
            stamina.ImageAlign = ContentAlignment.MiddleLeft;
            luck.Visible = true;
            Image luckstat = new Bitmap("luckstat.png");
            luck.Image = luckstat;
            luck.ImageAlign = ContentAlignment.MiddleLeft;
            Image Coinsstat = new Bitmap("Coinsstat.png");
            Coins.Image = Coinsstat;
            Coins.ImageAlign = ContentAlignment.MiddleLeft;
            Coins.Visible = true;
            Image Kardstat = new Bitmap("Kard.png");
            felszereles.Image = Kardstat;
            felszereles.ImageAlign = ContentAlignment.TopLeft;
            felszereles.Visible = true;
            Image vertstat = new Bitmap("Bőrvért.png");
            felszereles2.Image = vertstat;
            felszereles2.ImageAlign = ContentAlignment.TopLeft;
            felszereles2.Visible = true;
            elelmiszer.Visible = true;
            ekkovek.Visible = true;
        }
        private void Second_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jó választás utazó!\n" + "Választásod: Szerencse ital!", "Sikeres választás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invlist.Add("Szerencse ital");
            potionselect.Visible = false;
            eletero.Visible = false;
            szerencse.Visible = false;
            ugyesseg.Visible = false;
            SzovegList[0].Visible = true;
            tovabb.Visible = true;
            italok.Visible = true;
            Image myimage = new Bitmap("luck.png");
            italok.Image = myimage;
            italok.ImageAlign = ContentAlignment.TopLeft;
            hp.Visible = true;
            Image hpstat = new Bitmap("hpstat.png");
            hp.Image = hpstat;
            hp.ImageAlign = ContentAlignment.MiddleLeft;
            stamina.Visible = true;
            Image staminastat = new Bitmap("staminastat.png");
            stamina.Image = staminastat;
            stamina.ImageAlign = ContentAlignment.MiddleLeft;
            luck.Visible = true;
            Image luckstat = new Bitmap("luckstat.png");
            luck.Image = luckstat;
            luck.ImageAlign = ContentAlignment.MiddleLeft;
            Image Coinsstat = new Bitmap("Coinsstat.png");
            Coins.Image = Coinsstat;
            Coins.ImageAlign = ContentAlignment.MiddleLeft;
            Coins.Visible = true;
            Image Kardstat = new Bitmap("Kard.png");
            felszereles.Image = Kardstat;
            felszereles.ImageAlign = ContentAlignment.TopLeft;
            felszereles.Visible = true;
            Image vertstat = new Bitmap("Bőrvért.png");
            felszereles2.Image = vertstat;
            felszereles2.ImageAlign = ContentAlignment.TopLeft;
            felszereles2.Visible = true;
            elelmiszer.Visible = true;
            ekkovek.Visible = true;
        }
        private void Third_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jó választás utazó!\n" + "Választásod: Ügyesség ital!", "Sikeres választás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invlist.Add("Ügyesség ital");
            potionselect.Visible = false;
            eletero.Visible = false;
            szerencse.Visible = false;
            ugyesseg.Visible = false;
            SzovegList[0].Visible = true;
            tovabb.Visible = true;
            italok.Visible = true;
            Image myimage = new Bitmap("skill.png");
            italok.Image = myimage;
            italok.ImageAlign = ContentAlignment.TopLeft;
            hp.Visible = true;
            Image hpstat = new Bitmap("hpstat.png");
            hp.Image = hpstat;
            hp.ImageAlign = ContentAlignment.MiddleLeft;
            stamina.Visible = true;
            Image staminastat = new Bitmap("staminastat.png");
            stamina.Image = staminastat;
            stamina.ImageAlign = ContentAlignment.MiddleLeft;
            luck.Visible = true;
            Image luckstat = new Bitmap("luckstat.png");
            luck.Image = luckstat;
            luck.ImageAlign = ContentAlignment.MiddleLeft;
            Image Coinsstat = new Bitmap("Coinsstat.png");
            Coins.Image = Coinsstat;
            Coins.ImageAlign = ContentAlignment.MiddleLeft;
            Coins.Visible = true;
            Image Kardstat = new Bitmap("Kard.png");
            felszereles.Image = Kardstat;
            felszereles.ImageAlign = ContentAlignment.TopLeft;
            felszereles.Visible = true;
            Image vertstat = new Bitmap("Bőrvért.png");
            felszereles2.Image = vertstat;
            felszereles2.ImageAlign = ContentAlignment.TopLeft;
            felszereles2.Visible = true;
            elelmiszer.Visible = true;
            ekkovek.Visible = true;
        }
        private void Tovabb_Click(object sender, EventArgs e)
        {           
            int choice60 = -1;
            int choice61 = -1;
            int choice62 = -1;

            switch (currentIndex)
            {
                case 0:
                    tovabb.Text = "Tovabb";
                    SzovegList[0].Visible = false;
                    SzovegList[1].Visible = true;
                    SzovegList[1].Text = "#41\nAz alagút, bár folyamatosan jobbra-balra kanyarog, nagyjából mégis tartja az északi irányt, végül élesen oldalra kanyarodik, és ekkor majdnem belefutsz egy fekete köpenybe öltözött alakba. Tört tart a kezében, az arcán ülő tekintet rettegésről árulkodik! Rájössz, hogy nem te vagy az egyetlen, akit most próbára tesznek, és hogy mindketten ugyanazon Szobor után kutattok. A fickó rád veti magát, nyilvánvaló, hogy mielőbb végezni akar veled. Harcolnod kell!";
                    currentIndex++;
                    break;
                case 1:
                    tovabb.Visible = false;
                    SzovegList[1].Visible = false;
                    Tolvaj(7, 6);
                    tovabb.Visible = true;
                    tovabb.Text = "Tovabb";
                    SzovegList[87].Visible = true;
                    SzovegList[87].Text = "#85\nA Tolvajnál mindössze 3 Aranytallért és egy háromszög alakú, penészes gyümölcsöt találsz. Még soha nem láttál ehhez hasonlót, de gyanítod, hogy ez lehet a Xentos, a hosszú élet gyümölcse. Ha nem lenne ilyen borzalmas állapotban, gond nélkül megkockáztatnád, hogy belekóstolj, igy azonban úgy döntesz, hogy itt hagyod és folytatod az utad észak felé. Hamarosan egy útelágazáshoz érsz. Ha továbbra is északnak tartasz, lapozz a 108-ra. Ha a nyugati irányba leágazó új járaton mennél tovább, lapozz a 147-re.";
                    currentIndex++;
                    int choice = GetUserChoice();
                    if (choice == 108)
                    {
                        currentIndex = 108;
                    }else if (choice == 147)
                    {
                        currentIndex = 147;
                    }
                    break;
                case 108:
                    tovabb.Text = "Tovabb";
                    SzovegList[87].Visible = false;
                    SzovegList[108].Visible = true;
                    Nyeremeny.Visible = false;
                    SzovegList[108].Text = "#108\nÉszaki irányba követed az átjárót. Hamarosan elérsz egy keleti leágazáshoz. Hogyha egyenesen mész tovább, lapozz a 146-ra. Ha letérsz jobbra, lapozz a 79-re.";
                    currentIndex++;
                    int choice2 = GetUserChoice2();
                    if (choice2 == 146)
                    {
                        currentIndex = 146;
                    }
                    else if (choice2 == 79)
                    {
                        currentIndex = 79;
                    }
                    break;
                case 147:
                    tovabb.Text = "Tovabb";
                    SzovegList[87].Visible = false;
                    SzovegList[147].Visible = true;
                    Nyeremeny.Visible = false;
                    SzovegList[147].Text = "#147\nA járat egy ajtóban végződik. Hogyha ki szeretnéd nyitni, lapozz a 22-re. Ha visszatérnél az elágazáshoz, és észak felé folytatnád az utad, lapozz a 108-ra.";
                    currentIndex++;
                    int choice4 = GetUserChoice4();
                    if (choice4 == 22)
                    {
                        currentIndex = 22;
                        SzovegList[147].Visible = false;
                        SzovegList[22].Visible = true;
                        SzovegList[22].Text = "#22\nAz ajtó egy kis terembe nyílik. Egyik sarkában, egy kosárban egy hatalmas, kutyaszerű teremtmény hever. A szemben lévő falon egy ajtót látsz, mely mellett szögre akasztva egy Bronz Kulcs lóg hívogatóan. Ha megpróbálsz csendben átlopózni a helyiségen, lapozz a 81-re. Ha semmiképp nem akarod felkelteni a kutyát, és az ajtó becsukása után inkább visszatérnél az elágazáshoz, hogy észak felé folytasd az utad. lapozz a 108-ra.";
                        currentIndex++;
                        int choice66 = GetUserChoice66();
                        if (choice66 == 81)
                        {
                            currentIndex = 81;
                        }
                        else if (choice66 == 108)
                        {
                            currentIndex = 108;
                            SzovegList[22].Visible = false;
                            SzovegList[108].Visible = true;
                            SzovegList[108].Text = "#108\nÉszaki irányba követed az átjárót. Hamarosan elérsz egy keleti leágazáshoz. Hogyha egyenesen mész tovább, lapozz a 146-ra. Ha letérsz jobbra, lapozz a 79-re.";
                            int choice67 = GetUserChoice67();
                            if (choice67 == 146)
                            {
                                currentIndex = 146;
                            }
                            else if (choice67 == 79)
                            {
                                currentIndex = 79;
                            }
                        }
                    }
                    else if (choice4 == 108)
                    {
                        currentIndex = 108;
                        SzovegList[147].Visible = false;
                        SzovegList[108].Visible = true;
                        SzovegList[108].Text = "#108\nÉszaki irányba követed az átjárót. Hamarosan elérsz egy keleti leágazáshoz. Hogyha egyenesen mész tovább, lapozz a 146-ra. Ha letérsz jobbra, lapozz a 79-re.";
                        int choice5 = GetUserChoice5();
                        if (choice5 == 146)
                        {
                            currentIndex = 146;
                        }
                        else if (choice5 == 79)
                        {
                            currentIndex = 79;
                        }
                    }

                    break;
                case 22:
                    tovabb.Text = "Tovabb";
                    SzovegList[147].Visible = false;
                    SzovegList[22].Visible = true;
                    SzovegList[22].Text = "#22\nAz ajtó egy kis terembe nyílik. Egyik sarkában, egy kosárban egy hatalmas, kutyaszerű teremtmény hever. A szemben lévő falon egy ajtót látsz, mely mellett szögre akasztva egy Bronz Kulcs lóg hívogatóan. Ha megpróbálsz csendben átlopózni a helyiségen, lapozz a 81-re. Ha semmiképp nem akarod felkelteni a kutyát, és az ajtó becsukása után inkább visszatérnél az elágazáshoz, hogy észak felé folytasd az utad. lapozz a 108-ra.";
                    currentIndex++;
                    int choice42 = GetUserChoice42();
                    if (choice42 == 81)
                    {
                        currentIndex = 81;
                    }else if (choice42 == 108)
                    {
                        currentIndex = 108;
                        SzovegList[22].Visible = false;
                        SzovegList[108].Visible = true;
                        SzovegList[108].Text = "#108\nÉszaki irányba követed az átjárót. Hamarosan elérsz egy keleti leágazáshoz. Hogyha egyenesen mész tovább, lapozz a 146-ra. Ha letérsz jobbra, lapozz a 79-re.";
                        int choice5 = GetUserChoice5();
                        if (choice5 == 146)
                        {
                            currentIndex = 146;
                        }
                        else if (choice5 == 79)
                        {
                            currentIndex = 79;
                        }
                    }
                    break;
                case 81:
                    tovabb.Text = "Tovabb";
                    SzovegList[22].Visible = false;
                    SzovegList[81].Visible = true;
                    SzovegList[81].Text = "#81\nOlyan csendben lopakodsz előre, amennyire csak tudsz, ám kardod véletlenül nekicsapódik a kőnek, és éles, csengő hangot ad ki. Tedd próbára SZERENCSED! Ha szerencsés vagy, lapozz a 97-re. Ha nincs szerencséd, lapozz a 138-ra.";
                    currentIndex++;
                    int choice43 = GetUserChoice43();
                    if (choice43 == 97)
                    {
                        currentIndex = 97;
                    }else if(choice43 == 138)
                    {
                        currentIndex = 138;
                    }
                    break;
                case 97:
                    tovabb.Text = "Tovabb";
                    SzovegList[81].Visible = false;
                    SzovegList[97].Visible = true;
                    SzovegList[97].Text = "#97\nKezed egyből a kardod markolatára teszed, hogy elállítsd a csengő hangot. A kutya mocorog egy kicsit, de nem ébred fel. Szíved a torkodban dobog, ahogy haladsz, de végül gond nélkül elérsz a túloldalra, leemeled a kulcsot a szögről, csendesen kinyitod az ajtót és becsapod magad mögött. Miközben odakinn ráfordítod a kulcsot, a túloldalról félelmetes morgást és repedő fa hangja szűrődik át, ahogy az állat újra és újra nekiugrik. Lapozz a 30-ra.";
                    currentIndex++;
                    int choice44 = GetUserChoice44();
                    if (choice44 == 30)
                    {
                        currentIndex = 30;
                    }
                    break;
                case 138:
                    tovabb.Text = "Tovabb";
                    SzovegList[81].Visible = false;
                    SzovegList[138].Visible = true;
                    SzovegList[138].Text = "#138\nKardodhoz kapsz, de elkéstél. Az állat meghallotta a zajt és felébredt. Rémülten nézed, ahogy először egy, majd két pofa emelkedik fel, hogy a levegőbe szagoljon. Ez nem egy egyszerű kutya, vagy netán farkas. Ez egy rémséges Xlaia, ami legjobb tudomásod szerint körülbelül száz éve halt ki. A falhoz ugrasz, mert tudod, hogy védened kell majd hátadat, és előhúzott karddal készülsz fel a lény támadására. A Xlaia morogva ugrik ki kosarából. Mindkét vicsorgó pofából sárga agyarak lógnak elő, melyeken még ott piroslik legutóbbi ebédjük vére. Hogy még rosszabb legyen a helyzet, a lény szájaiból hosszú, nyálkás szálakban lóg a nyál, ami azt jelenti, hogy ez a fenevad veszett! Bár lenne nálad némi víz, hogy távol tartsd magadtól, ahogy a fenti világban is tennéd. A teremtmény jobbra-balra lengeti fejeit. miközben közeledik feléd. Meg kell küzdened vele!";
                    currentIndex++;
                    Xlaia(8,7);
                    int choice45 = GetUserChoice45();
                    if (choice45 == 100)
                    {
                        currentIndex = 100;
                    }
                    break;
                case 30:
                    SzovegList[138].Visible = false;
                    SzovegList[0].Visible = false;
                    SzovegList[1].Visible = false;
                    SzovegList[97].Visible = false;
                    SzovegList[30].Visible = true;
                    SzovegList[30].Text = "#30\nA járat nyugati irányba indul, ám hamarosan északnak fordul. Végül elérsz egy ajtóig. mely a keleti falban áll. Ha be akarsz nyitni rajta, lapozz a 124-re. Ha a folyosón folytatnád az utad, lapozz a 129-re.";
                    currentIndex++;
                    int choice47 = GetUserChoice47();
                    if (choice47 == 124)
                    {
                        currentIndex = 124;
                    }
                    else if (choice47 == 129)
                    {
                        currentIndex = 129;
                    }
                    break;
                case 100:
                    tovabb.Text = "Tovabb";
                    SzovegList[138].Visible = false;
                    SzovegList[100].Visible = true;
                    SzovegList[100].Text = "#100\nA szörnyeteg holtan hever elötted. Nyáladzó pofájának tartalmát gyorsan magába szívja a poros talaj. Karmai színaranyak; egyesével letéped öket a hatalmas mancsról, majd zsebre vágod öket. Ezután leemeled a kulcsot a szegről, kinyitod az ajtót és távozol. Lapozz a 30-ra.";
                    currentIndex++;
                    int choice46 = GetUserChoice46();
                    if (choice46 == 30)
                    {
                        currentIndex = 30;
                        SzovegList[0].Visible = false;
                        SzovegList[1].Visible = false;
                        SzovegList[100].Visible = false;
                        SzovegList[30].Visible = true;
                        SzovegList[30].Text = "#30\nA járat nyugati irányba indul, ám hamarosan északnak fordul. Végül elérsz egy ajtóig. mely a keleti falban áll. Ha be akarsz nyitni rajta, lapozz a 124-re. Ha a folyosón folytatnád az utad, lapozz a 129-re.";
                        currentIndex++;
                        int choice48 = GetUserChoice48();
                        if (choice48 == 124)
                        {
                            currentIndex = 124;
                        }else if(choice48 == 129)
                        {
                            currentIndex = 129;
                            SzovegList[30].Visible = false;
                            SzovegList[129].Visible = true;
                            SzovegList[129].Text = "#129\nHamarosan egy újabb elágazáshoz érsz. Ha kelet felé mennél tovább. lapozz a 112-re. Hogyha északnak folytatnád az utad, lapozz a 66-ra.";
                            currentIndex++;
                            int choice50 = GetUserChoice50();
                            if (choice50 == 112)
                            {
                                currentIndex = 112;
                            }
                            else if (choice50 == 66)
                            {
                                currentIndex = 66;
                            }
                        }
                    }
                    break;
                case 64:
                    SzovegList[124].Visible = false;
                    SzovegList[64].Visible = true;
                    SzovegList[64].Text = "#64\nAhogy leugrasz, hátizsákod beleakad valamibe, te pedig egy pillanatra elveszted az egyensúlyod, épp mikor földet érsz. Tedd próbára SZERENCSED! Ha szerencséd van, lapozz a 117-re. Hogyha nincs szerencséd, lapozz a 186-ra.";
                    currentIndex++;
                    int choice52 = GetUserChoice52();
                    if (choice52 == 117)
                    {
                        currentIndex = 117;
                    }else if (choice52 == 186)
                    {
                        currentIndex = 186;
                    }
                    break;
                case 66:
                    SzovegList[129].Visible = false;
                    SzovegList[66].Visible = true;
                    SzovegList[66].Text = "#66\nEgy lépcsősorhoz érsz, és már épp lefelé indulnál rajtuk, mikor a hátad mögött valami zaj veszélyre figyelmeztet. Megperdülsz, és egy alacsony, köpcös alakot pillantasz meg. Ocsmány arca undok vigyorra húzódik. Háta mögül elökap egy tüskés buzogányt, majd a hírhedt Sikító Szellemet is megszégyenítő csataüvöltéssel megpörgeti, és a karodba vágja. Vesztesz 1 ÉLETERÓ pontot. Meg kell küzdened vele.";
                    currentIndex++;
                    torpe(8,5);
                    int choice53 = GetUserChoice53();
                    if (choice53 == 118)
                    {
                        currentIndex = 118;
                    }
                    break;
                case 118:
                    SzovegList[66].Visible = false;
                    SzovegList[118].Visible = true;
                    SzovegList[118].Text = "#118\nEgy három ajtós terembe lépsz be. Azon kívül, amin át beléptél, látsz még egyet a szemközti falon és egyet magad mellett, mely valószínűleg arra megy vissza, amerröl jöttél, csak esetleg egy másik szintre.\r\nLapozz a 145-re.";
                    currentIndex++;
                    int choice55 = GetUserChoice55();
                    if (choice55 == 145)
                    {
                        currentIndex = 145;
                    }
                    break;
                case 145:
                    SzovegList[118].Visible = false;
                    SzovegList[145].Visible = true;
                    SzovegList[145].Text = "#145\nA helyiség közepén egy 30 Aranytallérból épített csillogó kupac áll. Óvatosan, az esetleges csapdákra odafigyelve teszed öket zsebre. Ha további érmék után akarod átkutatni a sarkokat, lapozz a 36-ra. Hogyha inkább távoznál az északi ajtón át, lapozz a 98-ra.";
                    currentIndex++;
                    int choice56 = GetUserChoice56();
                    if (choice56 == 36)
                    {
                        currentIndex = 36;
                    }else if (choice56 == 98)
                    {
                        currentIndex = 98;
                    }
                    break;
                case 98:
                    SzovegList[145].Visible = false;
                    SzovegList[98].Visible = true;
                    SzovegList[98].Text = "#98\nAz ajtó ugyan zárva van, de a korábban talált kulccsal gond nélkül sikerül kinyitnod. Ahogy belépsz, két dárda repül elő az ajtóban lévő egyik lyukból. Tedd próbára SZERENCSED! Ha a szerencsés vagy, lapozz a 44-re. Ha nincs szerencséd, lapozz a 8-ra.";
                    currentIndex++;
                    int choice59 = GetUserChoice59();
                    if (choice59 == 44)
                    {
                        currentIndex = 44;
                    }
                    else if (choice59 == 8)
                    {
                        currentIndex = 8;
                    }
                    break;
                    

                case 44:
                    SzovegList[98].Visible = false;
                    SzovegList[44].Visible = true;
                    SzovegList[44].Text = "#44\nDöbbenetes előrelátásodtól vezérelve eleve gyanítottad, hogy itt egy csapda vár rád, így sikerül felreugranod anélkül, hogy a lövedékek eltalálnának, mindkettő ártalmatlanul hull a földre. Lapozz a 65-re.";
                    currentIndex++;
                    choice60 = GetUserChoice60();
                    if (choice60 == 65)
                    {
                        currentIndex = 65;
                    }
                    break;

                case 8:
                    SzovegList[98].Visible = false;
                    SzovegList[8].Visible = true;
                    SzovegList[8].Text = "#8\nA dárdák, melyeket egy igen hatásos méreggel kentek be, mélyen a lábadba fúródnak. Dobj egy kockával, hogy megtudd, hány ÉLETERŐ pontot vesztettél. Lapozz a 65-re.";
                    currentIndex++;
                    choice61 = GetUserChoice61();
                    if (choice61 == 65)
                    {
                        currentIndex = 65;
                    }
                    break;
                case 65:
                    if (choice60 == 65)
                    {
                        SzovegList[44].Visible = false;
                    }
                    else if (choice61 == 65)
                    {
                        SzovegList[8].Visible = false;
                    }
                    SzovegList[65].Visible = true;
                    SzovegList[65].Text = "#65\nAz ajtó egy nyirkos folyosóra vezet, mely először kelet felé fordul, végül pedig északra kanyarodik. Elindulsz. Lapozz a 84-re.";
                    currentIndex++;

                    choice62 = GetUserChoice62();
                    if (choice62 == 84)
                    {
                        currentIndex = 84;
                    }
                    break;
                case 84:
                    SzovegList[65].Visible = false;
                    SzovegList[84].Visible = true;
                    SzovegList[84].Text = "#84\nBalodon egy masszív tölgyfa ajtót látsz, melyet acélszegecsek hada tarkit. Kilincse, mely az ajtólap közepéből mered kifelé, leginkább egy hatalmas madárra emlékeztet. Könnyen megeshet, hogy ez a díszes kapu a Szobrot őrzi! Ha be szeretnél nyitni. lapozz a 157-re. Ha úgy gondolod, ez túl nyilvánvaló megoldás lenne és tovább mennél észak felé, lapozz a 125-re.";
                    currentIndex++;
                    int choice63 = GetUserChoice63();
                    if (choice63 == 157)
                    {
                        currentIndex = 157;
                    }else if (choice63 == 125)
                    {
                        currentIndex = 125;
                    }
                    break;
                case 157:
                    SzovegList[84].Visible = false;
                    SzovegList[157].Visible = true;
                    SzovegList[157].Text = "#157\nAz ajtó egy kicsi, szellősen berendezett szobába nyílik. Hangos horkolás hangját hallod, melynek forrása, úgy tűnik, egy szék, mely háttal áll neked: ritka, szürke színü hajtincset vélsz látni felette. Óvatosan megkerülöd az elötted álló asztalt és megvizsgálod az alvó férfit. Egy idős férfi az, aki összefont kézzel alszik a kényelmetlen ülőalkalmatosságon. Az északi falon egy újabb ajtót látsz. Ha ez utóbbin át távoznál, lapozz a 180-ra. Hogyha távozol a helyiségből és a folyosón mész tovább, lapozz a 125-re. Ha előbb szétnéznél idebenn, lapozz a 166-ra.";
                    currentIndex++;//3gomb
                    break;
                case 125:
                    SzovegList[84].Visible = false;
                    SzovegList[125].Visible = true;
                    SzovegList[125].Text = "#125\nEgy hosszú lépcsősor lábához érkezel. A felfelé vezető út korántsem olyan nehéz, mint amitől tartottál. Nyersz 1 SZERENCSE pontot. Lapozz a 142-re.";
                    currentIndex++;
                    int choice64 = GetUserChoice64();
                    if (choice64 == 142)
                    {
                        currentIndex = 142;
                    }
                    break;
                case 142:
                    SzovegList[125].Visible = false;
                    SzovegList[142].Visible = true;
                    SzovegList[142].Text = "#142\nA lépcsősor végül egy járatba torkollik, ami kiszélesedik. Lélegzetelállító táj tárul a szemed elé. A folyosó egy széles szirtben ér véget. egy hatalmas barlangüreg falának kellős közepén. Óvatosan a szegély széléhez lépsz és letekintesz. Az egyik oldalon lépcsősort pillantasz meg, ami egészen a barlang mélyére ereszkedik le. Odalenn egy gyors folyású folyót látsz, amit ha el akarsz érni, kénytelen leszel cikkcakkban lemászni a semmilyen védelmet nem adó lépcsőkön. Az üreg olyan hatalmas, hogy saját légköre van. Ez az egyetlen lehetőséged a lejutásra, úgyhogy nagyon óvatosan haladsz. Végül földet érsz.. Lapozz a 27-re.";
                    currentIndex++;
                    int choice65 = GetUserChoice65();
                    if (choice65 == 27)
                    {
                        currentIndex = 27;
                    }
                    break;
                case 36:
                    SzovegList[145].Visible = false;
                    SzovegList[36].Visible = true;
                    SzovegList[36].Text = "#36\nSemmit nem találsz, így északra folytatod az utad. Lapozz a 98-ra.";
                    currentIndex++;
                    int choice57 = GetUserChoice57();
                    if (choice57 == 98)
                    {
                        currentIndex = 98;
                        SzovegList[36].Visible = false;
                        SzovegList[98].Visible = true;
                        SzovegList[98].Text = "#98\nAz ajtó ugyan zárva van, de a korábban talált kulccsal gond nélkül sikerül kinyitnod. Ahogy belépsz, két dárda repül elő az ajtóban lévő egyik lyukból. Tedd próbára SZERENCSED! Ha a szerencsés vagy, lapozz a 44-re. Ha nincs szerencséd, lapozz a 8-ra.";
                        currentIndex++;
                        int choice58 = GetUserChoice58();
                        if (choice58 == 44)
                        {
                            currentIndex = 44;
                        }else if(choice58 == 8)
                        {
                            currentIndex = 8;
                        }
                    }
                    break;
                case 112:
                    SzovegList[129].Visible = false;
                    SzovegList[112].Visible = true;
                    SzovegList[112].Text = "#112\nAhogy a folyosón haladsz, csoszogó léptek zaja üti meg a füledet. Kardodat előhúzva vársz, de egy öregember bukkan fel előtted. Esdekelni kezd: „Kímélj meg! Csak egy egyszerű ember vagyok, aki évekkel ezelőtt került ide.” Elmondja, hogy sérülése miatt itt rekedt, és már túl öreg a kijutáshoz. Megkérdezi tőled, merre találja a bejáratot. Ha megmondod neki, lapozz a 187-re. Ha rossz utat mondasz, lapozz a 156-ra.";
                    currentIndex++;
                    int choice54 = GetUserChoice54();
                    if (choice54 == 187)
                    {
                        currentIndex = 187;
                    }else if (choice54 == 156)
                    {
                        currentIndex = 156;
                    }
                    break;
                case 124:
                    SzovegList[30].Visible = false;
                    SzovegList[124].Visible = false;
                    SzovegList[124].Text = "#124\nAz ajtó egy teljesen üres szobába nyílik. A padlón egy nagy lyuk tátong. Ahogy a szélére lépsz és letekintesz, látod, hogy nem túl mély. Egy folyosó indul odalenn, mely szintén északi irányba halad tovább. Hogyha elhagyod a helyiséget és folytatod az utadat, lapozz a 129-re. Ha leereszkedsz az alsóbb szintre, és ott mész tovább, lapozz a 64-re.";
                    currentIndex++;
                    int choice49 = GetUserChoice49();
                    if (choice49 == 129)
                    {
                        currentIndex = 129;
                    }else if(choice49 == 64)
                    {
                        currentIndex = 64;
                    }
                    break;
                case 129:
                    SzovegList[124].Visible = false;
                    SzovegList[129].Visible = true;
                    SzovegList[129].Text = "#129\nHamarosan egy újabb elágazáshoz érsz. Ha kelet felé mennél tovább. lapozz a 112-re. Hogyha északnak folytatnád az utad, lapozz a 66-ra.";
                    currentIndex++;
                    int choice51 = GetUserChoice51();
                    if (choice51 == 112)
                    {
                        currentIndex = 112;
                    }else if(choice51 == 66)
                    {
                        currentIndex = 66;
                    }
                    break;
                case 146:
                    tovabb.Text = "Tovabb";
                    SzovegList[108].Visible = false;
                    SzovegList[146].Visible = true;
                    SzovegList[146].Text = "#146\nHamarosan egy ajtóhoz érsz, ami a nyugati falból nyílik. Ahogy végighúzod rajta a kezed, a kilincset keresve, egy keresztet sikerül kitapintanod rajta, amit nem túl mélyen véstek bele. Ha ki akarod nyitni az ajtót, lapozz az 51-re. Ha folytatnád az utad észak felé, lapozz a 80-ra.\r\n";
                    currentIndex++;
                    int choice3 = GetUserChoice3();
                    if (choice3 == 51)
                    {
                        currentIndex = 51;
                    }
                    else if (choice3 == 80)
                    {
                        currentIndex = 80;
                    }
                    break;
                case 79:
                    tovabb.Text = "Tovabb";
                    SzovegList[108].Visible = false;
                    SzovegList[79].Visible = true;
                    SzovegList[79].Text = "#79\nA keleti járat elég keskeny és sötét, és újabb leágazásba fut bele, ezúttal a balodon. Ha erre mennél tovább, északi irányba, lapozz a 141-re. Ha egyenesen folytatnád az utadat, lapozz a 122-re.";
                    currentIndex++;
                    int choice6 = GetUserChoice6();
                    if (choice6 == 141)
                    {
                        currentIndex = 141;
                    }
                    else if (choice6 == 122)
                    {
                        currentIndex = 122;
                    }
                    break;
                case 122:
                    tovabb.Text = "Tovabb";
                    SzovegList[79].Visible = false;
                    SzovegList[122].Visible = true;
                    SzovegList[122].Text = "#122\nAz alagút egy ideig kelet felé folytatódik. végül északra fordul. Ahogy a kanyar felé közeledsz, a szemben lévő falon egy lüktető fényfoltot veszel észre. Óvatosan nézel be balra. Lapozz a 144-re.\r\n";
                    currentIndex++;
                    int choice8 = GetUserChoice8();
                    if (choice8 == 144)
                    {
                        currentIndex = 144;
                    }
                    break;
                case 144:
                    tovabb.Text = "Tovabb";
                    SzovegList[122].Visible = false;
                    SzovegList[144].Visible = true;
                    SzovegList[144].Text = "#144\nMikor már félúton jársz a fényfolt felé, a talaj megnyílik alattad, de még az előtt sikerül visszalépned, hogy te is beleesnél, korábbi óvatosságod meghozta gyümölcsét. Ahogy közelebbről is megvizsgálod, megállapítod, hogy egy kis, kör alakú verem az a padló kellős közepén. Rozoga létra fut lefelé végig az oldalán. de vagy túl sötét van, vagy túl mély lyuk, mert nem látod az alját. Ha szét akarsz nézni benne, lapozz a 7-re. Ha inkább átugornád és kiderítenéd, mi a fényfolt forrása, lapozz a 96-ra.";
                    currentIndex++;
                    int choice10 = GetUserChoice10();
                    if (choice10 == 7)
                    {
                        currentIndex = 7;
                    }
                    else if (choice10 == 96)
                    {
                        currentIndex = 96;
                    }
                    break;
                case 7:
                    SzovegList[144].Visible = false;
                    SzovegList[7].Visible = true;
                    SzovegList[7].Text = "#7\nMikor végül eléred a verem alját, semmit nem látsz. A falakat végigtapogatva annyit meg tudsz állapítani, hogy az alagút kelet felé megy tovább. Ha a vaksötét ellenére is bevállalod ezt a járatot, lapozz a 165-re. Ha inkább visszatérnél a fenti folyosóra és északnak folytatnád az utad, lapozz a 96-ra.";
                    currentIndex++;
                    int choice69 = GetUserChoice69();
                    if (choice69 == 165)
                    {
                        currentIndex = 165;
                    }else if(choice69 == 96)
                    {
                        currentIndex = 96;
                    }
                    break;
                case 165:
                    SzovegList[7].Visible = false;
                    SzovegList[165].Visible = true;
                    SzovegList[165].Text = "#165\nA sötétben megbotlasz és elterülsz a padlón. Sikerült csúnyán megütnöd magad. Dobj egy kockával, hogy megtudd, hány ÉLETERŐ pontot vesztettél. Előre nyújtott kezeid szinte ugyanebben a pillanatban falba ütközik. Zsákutcába jutottál. Miközben az alagút falát keresed, fémes csörgés üti meg a füled, és lábaddal körbetapogatózva sikerül rálelned egy kis valamire a padlón. Zsebre teszed, majd miután visszamásztál a létrán a fénybe, alaposabban is megvizsgálod. Egy kis Aranykulcs az. Visszateszed a zsebedbe és észak felé indulsz. Lapozz a 96-ra.";
                    currentIndex++;
                    break;
                case 96:
                    SzovegList[7].Visible = false;
                    SzovegList[96].Visible = true;
                    SzovegList[96].Text = "#96\nAz alagút kanyarulata mögül túlvilági ragyogás árad. Ahogy a falra vetült játékot nézed, úgy érzed, a fény magától lüktet és változtatja a színét. Nagyon óvatosan fordulsz be a kanyarban, amin túl igen bizarr látvány fogad. Három nagyon alacsony, ezüstszínű, lebegő köpenybe öltözött alak táncol valamilyen rituális táncot a fény forrása körül. Az üreg falát itt mindenhol tükrök borítják, és a változó színek oda-vissza ugrálnak ezek közt, a lüktető ragyogástól erős szédülés tör rád. A forrás egy hatalmas kristály, mely egy magas talapzaton nyugszik, és képtelen vagy megállapítani, pontosan miféle kö is ez. Egyébként sincs idöd sokat spekulálni ezen, mivel az ezernyi tükörképnek köszönhetően az alakok felfigyelnek egy óvatlan mozdulatodra. A lények dühödten felkiáltva vetik rád magukat. Egy ellenfélként küzdj meg vele.";
                    currentIndex++;
                    ShowGameOver();
                    break;
                case 141:
                    tovabb.Text = "Tovabb";
                    SzovegList[79].Visible = false;
                    SzovegList[141].Visible = true;
                    SzovegList[141].Text = "#141\nA járat hamarosan egy ajtóban ér véget. Ha ki szeretnéd nyitni és belépnél rajta, lapozz a 107-re. Ha nem akarod tudni, mi vár rád odabenn és inkább visszamennél az elágazáshoz, hogy kelet felé folytasd az utad, lapozz a 122-re.";
                    currentIndex++;
                    int choice7 = GetUserChoice7();
                    if (choice7 == 107)
                    {
                        currentIndex = 107;
                    }
                    else if (choice7 == 122)
                    {
                        
                        currentIndex = 122;
                        SzovegList[0].Visible = false;
                        SzovegList[141].Visible = false;
                        SzovegList[122].Visible = true;
                        SzovegList[122].Text = "#122\nAz alagút egy ideig kelet felé folytatódik. végül északra fordul. Ahogy a kanyar felé közeledsz, a szemben lévő falon egy lüktető fényfoltot veszel észre. Óvatosan nézel be balra. Lapozz a 144-re.\r\n";
                        int choice9 = GetUserChoice9();
                        if (choice9 == 144)
                        {
                            currentIndex = 144;
                        }
                    }
                    break;
                case 107:
                    tovabb.Text = "Tovabb";
                    SzovegList[141].Visible = false;
                    SzovegList[107].Visible = true;
                    SzovegList[107].Text = "#107\nMivel az ajtó túloldaláról hangokat hallasz átszűrődni, óvatosan nyitsz be. Ahogy bekukucskálsz a túloldalon, egy üldögélő Orkot veszel észre. Remélve, hogy nem fogod érdekelni őt, megpróbálsz elsétálni mellette, ám mikor észrevesz, azonnal nyúl a kardjáért. A harc INDUL!";
                    currentIndex++;
                    Ork(6,5);
                    int choice71 = GetUserChoice71();
                    if (choice71 == 198)
                    {
                        currentIndex = 198;
                    }
                    break;
                case 198:
                    tovabb.Text = "Tovabb";
                    SzovegList[107].Visible = false;
                    SzovegList[198].Visible = false;
                    SzovegList[198].Text = "#198\nA földön találsz egy érdekes növénykét. Ha elég éhes vagy ahhoz, hogy megedd, vagy úgy sejted, valamilyen mágikus tulajdonsággal rendelkezik, lapozz a 49-re. Ha inkább hagyod, ahol van és az északi ajtón át távozol, lapozz a 152-re.";
                    currentIndex++;
                    int choice72 = GetUserChoice72();
                    if (choice72 == 49)
                    {
                        currentIndex = 49;
                    }
                    else if (choice72 == 152)
                    {
                        currentIndex = 152;
                    }
                    break;
                case 49:
                    tovabb.Text = "Tovabb";
                    SzovegList[198].Visible = false;
                    SzovegList[49].Visible = true;
                    SzovegList[49].Text = "#49\nA növénykének valóban különleges ereje volt – ám ahogy az utazó mohón felfalja, gyomrában lassan hideg borzongás fut végig. Egy pillanattal később lábai elgyengülnek, látása elhomályosul… majd teste élettelenül rogy a földre.";
                    currentIndex++;
                    ShowGameOver49();
                    break;
                case 152:
                    tovabb.Text = "Tovabb";
                    SzovegList[198].Visible = false;
                    SzovegList[152].Visible = true;
                    SzovegList[152].Text = "#152\nA járat, melyen most haladsz, elég keskeny, de még át tudod magad préselni a falak között. Balodon egy alagút fut be a folyosóba, te azonban eltökélten mész tovább egyenesen. Lapozz a 99-re.";
                    currentIndex++;
                    int choice73 = GetUserChoice73();
                    if (choice73 == 99)
                    {
                        currentIndex = 99;
                    }
                    break;
                case 99:
                    tovabb.Text = "Tovabb";
                    SzovegList[152].Visible = false;
                    SzovegList[99].Visible = true;
                    SzovegList[99].Text = "#99\nA fáklyák halovány fényében megpillantod a padlón kígyózó árnyakat – ám mielőtt reagálhatnál, jeges fájdalom hasít beléd. Csapdába léptél. A padló kattanva megnyílik alattad, és sikoltva zuhansz a feneketlen mélységbe.";
                    currentIndex++;
                    ShowGameOver99();
                    break;
                case 51:
                    tovabb.Text = "Tovabb";
                    SzovegList[146].Visible = false;
                    SzovegList[51].Visible = true;
                    SzovegList[51].Text = "#51\nEgy kis helyiségbe nyitsz be, mely első ránézésre nem tartalmaz semmi mást, csak nagy halom törmeléket a padlón. Ahogy beljebb lépsz, kellemetlen szag csapja meg az orrodat, és egy éles, magas és amenynyire meg tudod állapítani dühödt visitás kezd egyre erősödni. Végül egy rikoltás kiséretében két hatalmas Denevér ereszti el a plafont a szoba két sarkában, és feléd kezdenek repülni. Ahogy ösztönösen lebuksz, sikerül észrevenned a lények vicsorgó agyarait, melyek készek szétcincálni a torkodat. Ha gyorsan kihátrálsz, majd becsapod magad mögött a bejárati ajtót, lapozz a 80-ra. Hogyha megveted a lábad és megküzdesz ezekkel a szörnyű teremtményekkel, lapozz a 140-re.";
                    currentIndex++;
                    int choice11 = GetUserChoice11();
                    if (choice11 == 80)
                    {
                        currentIndex = 80;
                        SzovegList[0].Visible = false;
                        SzovegList[51].Visible = false;
                        SzovegList[80].Visible = true;
                        SzovegList[80].Text = "#80\nÉszak felé haladsz. Megszenvedsz az úttal, hisz eléggé hepchupás. Hamarosan elérsz egy elágazáshoz. A nyugat felé továbbinduló szakasz még rosszabb állapotúnak tűnik, mint az, ahol most jársz, ezért úgy döntesz. továbbra is tartod az irányt. Lapozz a 89-re.";
                        int choice12 = GetUserChoice12();
                        if (choice12 == 89)
                        {
                            currentIndex = 89;
                        }
                    }
                    else if (choice11 == 140)
                    {
                        currentIndex = 140;
                    }
                    break;
                case 140:
                    tovabb.Text = "Tovabb";
                    SzovegList[51].Visible = false;
                    SzovegList[140].Visible = true;
                    SzovegList[140].Text = "#140\n";
                    currentIndex++;
                    ShowGameOver();
                    break;
                case 80:
                    tovabb.Text = "Tovabb";
                    SzovegList[146].Visible = false;
                    SzovegList[80].Visible = true;
                    SzovegList[80].Text = "#80\nÉszak felé haladsz. Megszenvedsz az úttal, hisz eléggé hepchupás. Hamarosan elérsz egy elágazáshoz. A nyugat felé továbbinduló szakasz még rosszabb állapotúnak tűnik, mint az, ahol most jársz, ezért úgy döntesz. továbbra is tartod az irányt. Lapozz a 89-re.";
                    currentIndex++;
                    int choice13 = GetUserChoice13();
                    if (choice13 == 89)
                    {
                        currentIndex = 89;
                    }
                    break;
                case 89:
                    tovabb.Text = "Tovabb";
                    SzovegList[80].Visible = false;
                    SzovegList[89].Visible = true;
                    SzovegList[89].Text = "#89\nA járat meredeken emelkedik, te pedig gyorsan fáradni kezdesz. Figyelmed ellankad, és nem veszed észre a padlóban lévő, meglazult kõdarabot. Megbotlasz és elesel, közben pajzsod a fal egyik repedésébe ékelődik. Miközben próbálod kiszabadítani, elferdül. Sérült pajzsod miatt a soron következő csatákban 2-vel csökkentened kell majd Támadóerődet. Morogva mész tovább. míg végül egy újabb elágazáshoz nem érsz. Hogyha a nyugati ágon folytatnád az utad, lapozz a 95-re. Ha egyenesen mész tovább, lapozz a 127-re.";
                    currentIndex++;
                    int choice14 = GetUserChoice14();
                    if (choice14 == 95)
                    {
                        currentIndex = 95;
                    }
                    else if (choice14 == 127)
                    {
                        currentIndex = 127;
                    }
                    break;
                case 95:
                    tovabb.Text = "Tovabb";
                    SzovegList[89].Visible = false;
                    SzovegList[95].Visible = true;
                    SzovegList[95].Text = "#95\nNyugati irányba mész, le egy lejtős járaton, míg el nem érsz egy újabb elágazást. Úgy gondolod, a déli út visszafelé vezetne, így észak felé indulsz. Lapozz a 153-ra.";
                    currentIndex++;
                    int choice15 = GetUserChoice15();
                    if (choice15 == 153)
                    {
                        currentIndex = 153;
                    }
                    break;
                case 153:
                    tovabb.Text = "Tovabb";
                    SzovegList[95].Visible = false;
                    SzovegList[153].Visible = true;
                    SzovegList[153].Text = "#153\nA járat szélesedni kezd, repedések és hasadékok jelennek meg a falakon. Zörgö hang szűrődik ki valahonnan, és az egyik lyukból két különös teremtmény ugrik elő. Az egyértelműen látszik, hogy az alvilág lakója, mivel bőre teljesen fehér, vad szemei pedig rózsaszínűek. Feje a farkáig ér, veszedelmes tüskék borítják hátát, melyek járás közben jobbra-balra inganak. A lény hátat fordít neked, és már kezdesz megörülni, hogy megijedt tőled és elmenekül. Mekkorát tévedtél! Ez egy mérges Sündisznó, és épp arra készül, hogy halálos tüskéit beléd löje. A harc indul!";
                    Suni(7, 5);
                    playerStats.Hp -= 3;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    currentIndex++;
                    int choice16 = GetUserChoice16();
                    if (choice16 == 42)
                    {
                        currentIndex = 42;
                    }
                    break;
                case 42:
                    tovabb.Text = "Tovabb";
                    SzovegList[153].Visible = false;
                    SzovegList[42].Visible = true;
                    SzovegList[42].Text = "#42\nA járat tovább szélesedik, végül egy hatalmas barlangüregben találod magad. Mindkét oldaladnál sztalagmitok és sztalaktitok meredeznek. Néhányuk hatalmas köoszloppá nőtt össze az idők folyamán, melyek mögött kimondhatatlan borzalmak lapulhatnak. Érzed, hogy a barlangban folyamatosan mozog a levegő, és rájössz, hogy ennek oka egy gyors folyású, igen veszedelmesnek tűnő folyó. Feltekintve szemeid követik a cseppköoszlopok vonalait, egészen addig, míg el nem tűnnek a plafont elrejtő végtelen sötétségben. Valahol a folyó mentén egy kis, nem túl bizalomgerjesztő híd körvonalát sikerül kivenni. Lapozz a 27-re.";
                    int choice17 = GetUserChoice17();
                    if (choice17 == 27)
                    {
                        currentIndex = 27;
                    }
                    break;
                case 27:
                    tovabb.Text = "Tovabb";
                    SzovegList[42].Visible = false;
                    SzovegList[27].Visible = true;
                    SzovegList[27].Text = "#27\nEgy hatalmas völgy lábánál állsz, melyet egy gyors folyású folyó vájt ki. Próbálsz valami megoldást találni az átkelésre. de csak egy kicsi, eléggé rozoga és korhadt hidat látsz. Ahogy megközelíted, a látod, amint két óriási termesz eszi a fát. Hófehér testükön igen nyugtalanítóan hat két vérvörös szemük. A lények bármelyike bármikor beléd marhatna. Ha sietsz, talán még sikerül átkelned rajta azelőtt, hogy végleg összeroskadna. A másik lehetőséged, hogy megpróbálsz átúszni a sebes folyón. Ha az első megoldást választod, lapozz a 40-re. Ha úgy gondolod, elég jó úszó vagy, és ezzel próbálkoznál, lapozz a 2-re.\r\n";
                    currentIndex++;
                    int choice18 = GetUserChoice18();
                    if (choice18 == 40)
                    {
                        currentIndex = 40;
                    }else if (choice18 == 2)
                    {
                        currentIndex = 2;
                    }
                    break;
                case 2:
                    tovabb.Text = "Tovabb";
                    SzovegList[27].Visible = false;
                    SzovegList[2].Visible = true;
                    SzovegList[2].Text = "#2\nA vízbe ugrasz, az áramlat azonban nagyon eros. Megpróbálsz a felszínen maradni, de ez nem könnyű. Lapozz a 148-ra.";
                    currentIndex++;
                    int choice70 = GetUserChoice70();
                    if (choice70 == 148)
                    {
                        currentIndex = 148;
                    }
                    break;
                case 148:
                    tovabb.Text = "Tovabb";
                    SzovegList[2].Visible = false;
                    SzovegList[148].Visible = false;
                    SzovegList[148].Text = "#148\nCsaknem megfulladsz, de kitartasz. Dobj két kockával. Ha az eredmény kevesebb vagy ugyanannyi, mint UGYESSÉG pontjaid száma, lapozz a 103-ra. Ha nagyobb, lapozz a 15-re.";
                    currentIndex++;
                    FulladasSkip();
                    break;
                case 40:
                    tovabb.Text = "Tovabb";
                    SzovegList[27].Visible = false;
                    SzovegList[40].Visible = true;
                    SzovegList[40].Text = "#40\nMiközben a termeszektől nyüzsgő építményen haladsz, az baljósan recseg-ropog a talpad alatt. Minden egyes lépéssel újabb darabjai esnek bele a vizbe. Végül már csak egyetlen kötél marad épen, ami az utolsó deszkadarabot tartja. Tedd próbára SZERENCSED! Ha szerencsés vagy, lapozz a 60-ra. Ha nem, lapozz a 75-re.";
                    currentIndex++;
                    int choice19 = GetUserChoice19();
                    if (choice19 == 60)
                    {
                        currentIndex = 60;
                    }else if (choice19 == 75)
                    {
                        currentIndex = 75;
                    }
                    break;
                case 60:
                    tovabb.Text = "Tovabb";
                    SzovegList[40].Visible = false;
                    SzovegList[60].Visible = true;
                    SzovegList[60].Text = "#60\nA hid épp elég ideig marad épen ahhoz, hogy átérj a túloldalra. Ahogy lelépsz róla, összeomlik. Lapozz a 76-ra.";
                    currentIndex++;
                    int choice20 = GetUserChoice20();
                    if (choice20 == 76)
                    {
                        currentIndex = 76;
                    }
                    break;
                case 76:
                    tovabb.Visible = false;
                    tovabb2.Visible = true;
                    tovabb3.Visible = true;
                    tovabb4.Visible = true;
                    tovabb5.Visible = true;
                    SzovegList[60].Visible = false;
                    SzovegList[76].Visible = true;
                    SzovegList[76].Text = "#76\nHomokos parton találod magad, melynek félhold alakja van. Az elötted lévő sziklafal egy kis alkóvot alkot, és három ajtót foglal magában. Ezek közül választhatsz majd, mikor eljön a távozás ideje, előtte azonban még el kell döntened, át akarod-e kutatni a folyópartot ékkövek vagy aranyérmék után. Hogyha az északi ajtón át távoznál, lapozz a 87-re. Ha a nyugatin lépnél be, lapozz a 6-ra. Ha a keletivel próbálnál szerencsét, lapozz a 111-re. Ha előbb átkutatnád a partot, lapozz az 53-ra.";
                    currentIndex++;
                    break;
            }
        }
        private void Tovabb2_Click(object sender, EventArgs e)
        {
            tovabb2.Text = "Tovabb";
            tovabb2.Size = new Size(600, 75);
            tovabb3.Visible= false;
            tovabb4.Visible= false;
            tovabb5.Visible= false;
            SzovegList[76].Visible = false;
            SzovegList[87].Visible = true;
            SzovegList[87].Text = "#87\nAz alagutat egy jókora, vasveretes ajtó zárja le. Megpróbálod lenyomni a kilincset, de zárva van. A méretes kulcslyukon átnézve nem sokat tudsz kivenni a túloldalból. Mikor a füledet hozzászorítod, tollak suhogását és fütyülés-szerű sóhajtást hallasz. Ha van nálad egy Arany Kulcs, lapozz a 13-ra. Ha nincsen, lapozz a 121-re.";
            currentIndex++;
            int choice21 = GetUserChoice21();
            if (choice21 == 13)
            {
                currentIndex = 13;
                SzovegList[121].Visible = false;
                SzovegList[87].Visible = false;
                SzovegList[13].Visible = true;
                SzovegList[13].Text = "#13\nA zárba helyezed a kulcsot, de az sajnos nem illik bele, így nincs más választásod, minthogy megpróbáld betörni. Lapozz a 196-ra.";
                currentIndex++;
                int choice22 = GetUserChoice22();
                if (choice22 == 196)
                {
                    currentIndex = 196;
                    SzovegList[121].Visible = false;
                    SzovegList[13].Visible = false;
                    SzovegList[196].Visible = true;
                    SzovegList[196].Text = "#196\nAmennyire csak tudod, puha ruhadarabokkal béleled ki a vállad, behúzod a nyakad és az ajtónak rontasz. Dobj egy kockával. Ha az eredmény 1-4. megsérültél és vesztesz 2 ÉLETERŐ pontot. Ha azonban 5-öt vagy 6-ot dobtál, sikerült betörnöd az ajtót lapozz a 158-ra. Egészen addig kell próbálkoznod. míg ez nem sikerül.\r\n";
                    currentIndex++;
                    BetorAjto();
                    SzovegList[121].Visible = false;
                    SzovegList[196].Visible = false;
                    SzovegList[158].Visible = true;
                    SzovegList[158].Text = "#158\nAz ajtó becsapódik, te pedig végre felfedezed a füttyszerű sóhajok és susogások forrását. Előtted, a padlón guggolva megpillantod a Galont, a Madárembert. Börszárnyai két oldalt széttárva állnak, kezének éles karmai feléd mutatnak. Azonnal felismered zöldes bőrét, és tudod, hogy izmos karjaival és hatalmas szárnyaival megpróbál majd megfullasztani. Előhúzod kardodat, melynek látványára ellenfeled azonnal örjöngeni kezd, hiszen éhsége kielégíthetetlen. Ez a harc lesz az egyik legnehezebb, amit meg kell itt vívnod.\r\n";
                    currentIndex++;
                    Galon(12, 8);
                    int choice23 = GetUserChoice23();
                    if (choice23 == 61)
                    {
                        currentIndex = 61;
                        SzovegList[121].Visible = false;
                        SzovegList[158].Visible = false;
                        SzovegList[61].Visible = true;
                        SzovegList[61].Text = "#61\nA hatalmas Galon tetemét melynek madárszerű karmai még mindig megfeszülnek és elernyednek, mintha még holtukban is szét akarnának tépni téged megkerülve kiutat keresel a helyiségből. E közben szépen lassan az oszlás büze tölti be a levegőt. A Madárember teste felé fordulsz, és még éppen megpillantod, amint bőrszárnyai eltünnek egy csapat vonagló lárva alatt. Néhány másodperccel később már csak a lerágott csontok maradnak meg egykori ellenfeledből. Amint elfogy élelmük, a férgek feled indulnak, te pedig ráébredsz, hogy halálos veszélyben vagy. Mivel a fura teremtmények közted és a bejárat között állnak, egy másik kiutat kell találnod. Tedd próbára SZERENCSED! Ha szerencséd van, lapozz a 109-re. Hogyha nincs szerencséd, lapozz a 175-re.\r\n";
                        currentIndex++;
                    }

                }
            }else if (choice21 == 121)
            {
                currentIndex = 121;
                SzovegList[87].Visible = false;
                SzovegList[121].Visible = true;
                SzovegList[121].Text = "#121\nNincs más választásod, minthogy a válladdal ronts neki az ajtónak. Nem lesz egy egyszerű feladat, mivel a szegecsek igen hosszúak és hegyesek. Lapozz a 196-ra.";
                currentIndex++;
                int choice22 = GetUserChoice22();
                if (choice22 == 196)
                {
                    currentIndex = 196;
                    SzovegList[121].Visible = false;
                    SzovegList[196].Visible = true;
                    SzovegList[196].Text = "#196\nAmennyire csak tudod, puha ruhadarabokkal béleled ki a vállad, behúzod a nyakad és az ajtónak rontasz. Dobj egy kockával. Ha az eredmény 1-4. megsérültél és vesztesz 2 ÉLETERŐ pontot. Ha azonban 5-öt vagy 6-ot dobtál, sikerült betörnöd az ajtót lapozz a 158-ra. Egészen addig kell próbálkoznod. míg ez nem sikerül.\r\n";
                    currentIndex++;
                    BetorAjto();
                    SzovegList[196].Visible = false;
                    SzovegList[158].Visible = true;
                    SzovegList[158].Text = "#158\nAz ajtó becsapódik, te pedig végre felfedezed a füttyszerű sóhajok és susogások forrását. Előtted, a padlón guggolva megpillantod a Galont, a Madárembert. Börszárnyai két oldalt széttárva állnak, kezének éles karmai feléd mutatnak. Azonnal felismered zöldes bőrét, és tudod, hogy izmos karjaival és hatalmas szárnyaival megpróbál majd megfullasztani. Előhúzod kardodat, melynek látványára ellenfeled azonnal örjöngeni kezd, hiszen éhsége kielégíthetetlen. Ez a harc lesz az egyik legnehezebb, amit meg kell itt vívnod.\r\n";
                    currentIndex++;
                    Galon(12, 8);
                    int choice23 = GetUserChoice23();
                    if (choice23 == 61)
                    {
                        currentIndex = 61;
                        SzovegList[121].Visible = false;
                        SzovegList[158].Visible = false;
                        SzovegList[61].Visible = true;
                        SzovegList[61].Text = "#61\nA hatalmas Galon tetemét melynek madárszerű karmai még mindig megfeszülnek és elernyednek, mintha még holtukban is szét akarnának tépni téged megkerülve kiutat keresel a helyiségből. E közben szépen lassan az oszlás büze tölti be a levegőt. A Madárember teste felé fordulsz, és még éppen megpillantod, amint bőrszárnyai eltünnek egy csapat vonagló lárva alatt. Néhány másodperccel később már csak a lerágott csontok maradnak meg egykori ellenfeledből. Amint elfogy élelmük, a férgek feled indulnak, te pedig ráébredsz, hogy halálos veszélyben vagy. Mivel a fura teremtmények közted és a bejárat között állnak, egy másik kiutat kell találnod. Tedd próbára SZERENCSED! Ha szerencséd van, lapozz a 109-re. Hogyha nincs szerencséd, lapozz a 175-re.\r\n";
                        currentIndex++;
                    }
                }
            }
            
        }//Kész a játékos vesztett
        private void Tovabb3_Click(object sender, EventArgs e)
        {
            tovabb3.Text = "Tovabb";
            tovabb3.Size = new Size(600, 75);
            tovabb3.Location = new Point(750, 850);
            tovabb2.Visible = false;
            tovabb4.Visible = false;
            tovabb5.Visible = false;
            SzovegList[76].Visible = false;
            SzovegList[6].Visible = true;
            SzovegList[6].Text = "#6\nAz ajtó egy nyugat felé haladó alagútba nyílik. Követed, míg egy elágazáshoz nem érsz. Ha észak felé akarsz fordulni, lapozz a 172-re. Ha nem akarsz letérni ebből a járatból. lapozz a 168-ra.";
            currentIndex++;
            int choice24 = GetUserChoice24();
            if (choice24 == 172)
            {
                currentIndex = 172;
                tovabb3.Visible = false;
                tovabb6.Visible = true;
                tovabb7.Visible = true;
                tovabb8.Visible = true;
                SzovegList[6].Visible = false;
                SzovegList[168].Visible = false;
                SzovegList[172].Visible = true;
                SzovegList[172].Text = "#172\nA folyosó gyorsan szélesedik, végül egy kisebb szoba méreteit ölti magára. Nem messze töled ismét összeszűkül, és újra egyszerű járatként folytatja életét. A padló közepén egy sekély aknát látsz. Ha gyorsan átgázolsz rajta, hogy a túloldalon folytathasd az utad, lapozz a 163-ra. Ha bele akarsz ugrani, lapozz a 185-rc. Ha visszatérnél az előző elágazáshoz, és ott nyugati irányba mennél tovább, lapozz a 168-ra.";
                currentIndex++;
                

            }
            else if (choice24 == 168)
            {
                currentIndex = 168;
                SzovegList[6].Visible = false;
                SzovegList[168].Visible = true;
                SzovegList[168].Text = "#168\nEgy újabb elágazáshoz érkezel. Ha észak felé mennél, lapozz a 161-re. Ha továbbra is nyugati irányba haladnál, lapozz a 73-ra.";

            }
        }
        private void Tovabb4_Click(object sender, EventArgs e)
        {
            tovabb4.Text = "Tovabb";
            tovabb4.Size = new Size(600, 75);
            tovabb3.Visible = false;
            tovabb2.Visible = false;
            tovabb5.Visible = false;
            SzovegList[76].Visible = false;
            SzovegList[111].Visible = true;
            SzovegList[111].Text = "#111\nAz alagút egyre szűkösebb lesz, és ahogy próbálsz előre haladni, a falak szorítani kezdenek. Légzésed nehezedik, és bár mindent megpróbálsz, egyszerűen már nem tudsz mozdulni. A körülötted lévő sötétség elnyel, és minden remény elveszik. ";
            currentIndex++;
            ShowGameOver111();
        }//Kész a játékos vesztett
        private void Tovabb5_Click(object sender, EventArgs e)
        {
            tovabb5.Text = "Tovabb";
            tovabb5.Size = new Size(600, 75);
            tovabb5.Location = new Point(750, 850);
            tovabb4.Visible = false;
            tovabb3.Visible = false;
            tovabb2.Visible = false;
            SzovegList[76].Visible = false;
            SzovegList[53].Visible = true;
            SzovegList[53].Text = "#53\nA part teljesen kihaltnak tűnik, te pedig eléggé óvatlanul járkálsz, így a homokban bujkáló apró, bíbor rák minden gond nélkül csíp bele a lábadba. A SZERVEZETED MEG LETT MÉRGEZVE. A két ajtó bármelyiken át távozhatsz. Ha az északi ajtón át távoznál, lapozz a 87-re. Ha a nyugatin lépnél be, lapozz a 6-ra.";
            currentIndex++;
            int choice74 = GetUserChoice74();
            if (choice74 == 87)
            {
                currentIndex = 87;
                SzovegList[53].Visible = false;
                SzovegList[6].Visible = false;
                SzovegList[87].Visible = true;
                SzovegList[87].Text = "#87\nAz alagutat egy jókora, vasveretes ajtó zárja le. Megpróbálod lenyomni a kilincset, de zárva van. A méretes kulcslyukon átnézve nem sokat tudsz kivenni a túloldalból. Mikor a füledet hozzászorítod, tollak suhogását és fütyülés-szerű sóhajtást hallasz. Ha legalább 5 ÉLETERŐD van, lapozz a 13-ra. Ha nincsen, lapozz a 121-re.";
                currentIndex++;
                int choice75 = GetUserChoice75();
                if (choice75 == 13)
                {
                    currentIndex = 13;
                    SzovegList[87].Visible = false;
                    SzovegList[121].Visible = false;
                    SzovegList[13].Visible = true;
                    SzovegList[13].Text = "#13\nHa idáig eljutottál jó úton haladsz! De ez sajnos nem minden, elötted egy ajtó van megpróbálod kinyitni és azt veszed észre, hogy... Lapozz a 6-ra!";
                    currentIndex++;
                    int choice76 = GetUserChoice76();
                    if (choice76 == 6)
                    {
                        currentIndex = 6;
                        SzovegList[13].Visible = false;
                        SzovegList[6].Visible = true;
                        SzovegList[6].Text = "#6\nAz ajtót kinyitva meglátsz egy pázsitot és hátra nézve össze omlik a labirintus, gyorsan átmész az ajtón és rá eszmélsz, hogy sikeresen kijutottál az ÍTÉLET LABIRINTUSÁBÓL!";
                        currentIndex++;
                        ShowWin();
                    }
                }else if (choice75 == 121)
                {
                    currentIndex = 121;
                    SzovegList[87].Visible = false;
                    SzovegList[13].Visible = false;
                    SzovegList[121].Visible = true;
                    SzovegList[121].Text = "#121\nNincs más választásod, minthogy a válladdal ronts neki az ajtónak. Nem lesz egy egyszerű feladat, mivel a szegecsek igen hosszúak és hegyesek. Első neki futásra megsérűlsz majd a hirtelen vérvezteségbe bele halsz!";
                    currentIndex++;
                    ShowGameOver121();
                }
            }else if (choice74 == 6)
            {
                currentIndex = 6;
                SzovegList[53].Visible = false;
                SzovegList[6].Visible = true;
                SzovegList[6].Text = "#6\nAz ajtót kinyitva meglátsz egy pázsitot és hátra nézve össze omlik a labirintus, gyorsan átmész az ajtón és rá eszmélsz, hogy sikeresen kijutottál az ÍTÉLET LABIRINTUSÁBÓL!";
                currentIndex++;
                ShowWin();
            }
        }//Kész a játékos Nyer/veszít
        private void Tovabb6_Click(object sender, EventArgs e)
        {
            tovabb6.Text = "Tovabb";
            tovabb6.Size = new Size(600, 75);
            tovabb7.Visible = false;
            tovabb8.Visible = false;
            tovabb3.Visible = false;
            tovabb2.Visible = false;
            SzovegList[172].Visible = false;
            SzovegList[163].Visible = true;
            SzovegList[163].Text = "#163\nAz alagút egy tágas, vízzel telt szobába vezet. A falakat misztikus minták borítják. Megmártózol a hűs vízben, de kijövet egy víz alatti kijáratot veszel észre. Nem tudod kinyitni, így végül visszaöltözöl és távozol. Visszatérsz a vermes ajtóhoz. Ha leugrasz, lapozz a 185-re. Ha inkább nyugat felé mész, lapozz a 168-ra.";
            currentIndex++;
            int choice25 = GetUserChoice25();
            if (choice25 == 185)
            {
                currentIndex = 185;
                SzovegList[163].Visible = false;
                SzovegList[169].Visible = false;
                SzovegList[185].Visible = true;
                SzovegList[185].Text = "#185\nLeugrasz a verembe, miután meggyözödtél róla, hogy ki fogsz tudni belőle mászni, ha ez szükségesnek bizonyulna. Mikor körbenézel, egy alacsony bejáratra bukkansz az egyik kinyúló szikladarab alatt. Szinte négykézlábra kell leereszkedned, hogy be tudj kukkantani rajta. Ha alaposabban is szét akarsz odabenn nézni, úgy lapozz a 178-ra. Ha inkább visszatérnél a szobába, lapozz a 172-re és válassz valami mást.";
                currentIndex++;
                int choice26 = GetUserChoice26();
                if (choice26 == 178)
                {
                    currentIndex = 178;
                    SzovegList[185].Visible = false;
                    SzovegList[169].Visible = false;
                    SzovegList[178].Visible = true;
                    SzovegList[178].Text = "#178\nAz alagút egyre alacsonyabbá és szűkebbé válik, így nehéz nem észrevenni az itt heverő kis, kék folyadékot tartalmazó üvegcsét. Lapozz a 34-re.";
                    currentIndex++;
                    int choice27 = GetUserChoice27();
                    if (choice27 == 34)
                    {
                        currentIndex = 34;
                        SzovegList[178].Visible = false;
                        SzovegList[169].Visible = false;
                        SzovegList[34].Visible = true;
                        SzovegList[34].Text = "#34\nA fiola erős mentaillatot áraszt magából. Ha meg akarod inni, lapozz a 102-re. Ha inkább hagyod, ahol van, lapozz a 169-re.";
                        currentIndex++;
                        int choice28 = GetUserChoice28();
                        if (choice28 == 102)
                        {
                            currentIndex = 102;
                            SzovegList[34].Visible = false;
                            SzovegList[169].Visible = false;
                            SzovegList[102].Visible = true;
                            SzovegList[102].Text = "#102\nMiután felhajtod az üvegcsében lévő italt, megdöbbenve tapasztalod, mennyivel jobban érzed most magad. Az üvegben a Szerencse Italának egy adagja volt. Növeld meg 1-el Kezdeti SZERENCSÉDET, majd állítsd vissza jelenlegi pontjaidat erre az új értékre. Folytatod a kúszást észak felé. Lapozz a 169-re.";
                            currentIndex++;
                            int choice29 = GetUserChoice29();
                            if (choice29 == 169)
                            {
                                currentIndex = 169;
                                SzovegList[102].Visible = false;
                                SzovegList[169].Visible = false;
                                SzovegList[169].Visible = true;
                                SzovegList[169].Text = "#169\nA folyosó végén egy kicsiny ajtót találsz. Ahogy figyelsz, különös, csobogó hangot hallasz átszűrődni rajta. Érintésedre különösen hűvösnek tűnik az anyaga. Ha ki akarod nyitni, lapozz a 164-re. Ha inkább\r\nhagyod, ahol van, lapozz vissza a 172-re és válassz valami mást.";
                                currentIndex++;
                                int choice30 = GetUserChoice30();
                                if (choice30 == 164)
                                {
                                    currentIndex = 164;
                                    SzovegList[169].Visible = false;
                                    SzovegList[164].Visible = true;
                                    SzovegList[164].Text = "#164\nAhogy lenyomod a kilincset, az ajtó kicsapódik, mintha valami hatalmas súly nyomná ki a túloldalon. Azonnal rájössz, hogy nagy hibát vétettél, mikor vízsugarak kezdenek el kispriccelni az apró réseken. Kétségbeesetten próbálod újra bezárni a kitörni készülő víztömeget ám hamar rájössz, hogy erre semmi esélyed, így más választásod nem lévén menekülni próbálsz. Az ajtó kicsapódik, a szűk járatban pedig esélyed sincs rá, hogy túléld a dolgot. A víz teljes tömege rád zúdul, te pedig azon nyomban megfulladsz. Kalandod itt véget ér.";
                                    currentIndex++;
                                    ShowGameOver();
                                }else if (choice30 == 172)
                                {
                                    currentIndex = 172;
                                    tovabb6.Text = "163";
                                    tovabb6.Size = new Size(150, 75);
                                    tovabb6.Location = new Point(750, 850);
                                    tovabb6.Visible = true;
                                    tovabb7.Visible = true;
                                    tovabb8.Visible = true;
                                    SzovegList[169].Visible = false;
                                    SzovegList[172].Visible = true;
                                    SzovegList[172].Text = "#172\nA folyosó gyorsan szélesedik, végül egy kisebb szoba méreteit ölti magára. Nem messze töled ismét összeszűkül, és újra egyszerű járatként folytatja életét. A padló közepén egy sekély aknát látsz. Ha gyorsan átgázolsz rajta, hogy a túloldalon folytathasd az utad, lapozz a 163-ra. Ha bele akarsz ugrani, lapozz a 185-rc. Ha visszatérnél az előző elágazáshoz, és ott nyugati irányba mennél tovább, lapozz a 168-ra.";
                                    currentIndex++;
                                }
                            }
                        }else if (choice28 == 169)
                        {
                            currentIndex = 169;
                            SzovegList[34].Visible = false;
                            SzovegList[169].Visible = true;
                            SzovegList[169].Text = "#169\nA folyosó végén egy kicsiny ajtót találsz. Ahogy figyelsz, különös, csobogó hangot hallasz átszűrődni rajta. Érintésedre különösen hűvösnek tűnik az anyaga. Ha ki akarod nyitni, lapozz a 164-re. Ha inkább\r\nhagyod, ahol van, lapozz vissza a 172-re és válassz valami mást.";
                            currentIndex++;
                            int choice30 = GetUserChoice30();
                            if (choice30 == 164)
                            {
                                currentIndex = 164;
                                SzovegList[169].Visible = false;
                                SzovegList[164].Visible = true;
                                SzovegList[164].Text = "#164\nAhogy lenyomod a kilincset, az ajtó kicsapódik, mintha valami hatalmas súly nyomná ki a túloldalon. Azonnal rájössz, hogy nagy hibát vétettél, mikor vízsugarak kezdenek el kispriccelni az apró réseken. Kétségbeesetten próbálod újra bezárni a kitörni készülő víztömeget ám hamar rájössz, hogy erre semmi esélyed, így más választásod nem lévén menekülni próbálsz. Az ajtó kicsapódik, a szűk járatban pedig esélyed sincs rá, hogy túléld a dolgot. A víz teljes tömege rád zúdul, te pedig azon nyomban megfulladsz. Kalandod itt véget ér.";
                                currentIndex++;
                                ShowGameOver();
                            }
                            else if (choice30 == 172)
                            {
                                currentIndex = 172;
                                tovabb6.Text = "163";
                                tovabb6.Size = new Size(150, 75);
                                tovabb6.Location = new Point(750, 850);
                                tovabb6.Visible = true;
                                tovabb7.Visible = true;
                                tovabb8.Visible = true;
                                SzovegList[169].Visible = false;
                                SzovegList[172].Visible = true;
                                SzovegList[172].Text = "#172\nA folyosó gyorsan szélesedik, végül egy kisebb szoba méreteit ölti magára. Nem messze töled ismét összeszűkül, és újra egyszerű járatként folytatja életét. A padló közepén egy sekély aknát látsz. Ha gyorsan átgázolsz rajta, hogy a túloldalon folytathasd az utad, lapozz a 163-ra. Ha bele akarsz ugrani, lapozz a 185-rc. Ha visszatérnél az előző elágazáshoz, és ott nyugati irányba mennél tovább, lapozz a 168-ra.";
                                currentIndex++;
                            }
                        }
                    }
                }else if (choice26 == 172)
                {
                    currentIndex = 172;
                    tovabb6.Text = "163";
                    tovabb6.Size = new Size(150, 75);
                    tovabb6.Location = new Point(750, 850);
                    tovabb6.Visible = true;
                    tovabb7.Visible = true;
                    tovabb8.Visible = true;
                    SzovegList[185].Visible = false;
                    SzovegList[172].Visible = true;
                    SzovegList[172].Text = "#172\nA folyosó gyorsan szélesedik, végül egy kisebb szoba méreteit ölti magára. Nem messze töled ismét összeszűkül, és újra egyszerű járatként folytatja életét. A padló közepén egy sekély aknát látsz. Ha gyorsan átgázolsz rajta, hogy a túloldalon folytathasd az utad, lapozz a 163-ra. Ha bele akarsz ugrani, lapozz a 185-rc. Ha visszatérnél az előző elágazáshoz, és ott nyugati irányba mennél tovább, lapozz a 168-ra.";
                    currentIndex++;
                }
            
            }else if (choice25 == 168)
            {
                currentIndex = 168;
                SzovegList[163].Visible = false;
                SzovegList[168].Visible = true;
                SzovegList[168].Text = "#168\nEgy újabb elágazáshoz érkezel. Ha észak felé mennél, lapozz a 161-re. Ha továbbra is nyugati irányba haladnál, lapozz a 73-ra.";
                currentIndex++;
                int choice31 = GetUserChoice31();
                if (choice31 == 161)
                {
                    currentIndex = 161;
                    tovabb6.Visible = false;
                    tovabb9.Visible = true;
                    tovabb10.Visible = true;
                    tovabb11.Visible = true;
                    SzovegList[73].Visible = false;
                    SzovegList[168].Visible = false;
                    SzovegList[161].Visible = true;
                    SzovegList[161].Text = "#161\nA járat egy négyzet alakú szobában ér véget, melyet a rothadó hús szaga tölt meg. A padló nagy részét két óriási, bugyborékoló sármedence teszi ki. Egy keskeny kifutó mely nem sokkal szélesebb, mint a lábfejed halad középen, a terem széleit pedig hasonlóan keskeny szegélyek futják körbe. Mindhárom út egy nyilásban fut össze az északi falon. Ha a jobboldalin haladnál végig. lapozz a 181-re. Ha a baloldalin, lapozz a 193-ra. Amennyiben a középső utat választanád, lapozz a 171-re.";
                    currentIndex++;
                }else if (choice31 == 73)
                {
                    currentIndex = 73;
                    SzovegList[168].Visible = false;
                    SzovegList[73].Visible = true;
                    SzovegList[73].Text = "#73\nTovábbra is nyugati irányba haladva észreveszed, hogy a járat egy kisebb sziklahalomban ér véget. Csákány és ásó nélkül itt esélyed sem lenne átjutni. Ahogy megfordulsz, hogy visszatérj az előző elágazáshoz, egy sötétebb folt egy újabb észak felé vezető alagút jelenlétét árulja el. Úgy döntesz, erre mész tovább. Lapozz a 174-re.";
                    currentIndex++;
                }
            }
        }
        private void Tovabb7_Click(object sender, EventArgs e)
        {
            tovabb7.Text = "Tovabb";
            tovabb7.Size = new Size(600, 75);
            tovabb6.Visible = false;
            tovabb8.Visible = false;
            tovabb3.Visible = false;
            tovabb2.Visible = false;
            SzovegList[172].Visible = false;
            SzovegList[163].Visible = true;
            SzovegList[185].Text = "#185\n";
        }
        private void Tovabb8_Click(object sender, EventArgs e)
        {
            tovabb8.Text = "Tovabb";
            tovabb8.Size = new Size(600, 75);
            tovabb6.Visible = false;
            tovabb7.Visible = false;
            tovabb3.Visible = false;
            tovabb2.Visible = false;
            SzovegList[172].Visible = false;
            SzovegList[163].Visible = true;
            SzovegList[168].Text = "#168\n";
        }
        private void Tovabb9_Click(object sender, EventArgs e)
        {
            tovabb9.Text = "Tovabb";
            tovabb9.Size = new Size(600,75);
            tovabb10.Visible = false;
            tovabb11.Visible = false;
            SzovegList[161].Visible = false;
            SzovegList[181].Visible = false;
            SzovegList[181].Text = "#181\nAhogy megkerülöd a medencét, látod, amint a sár bugyogni kezd. Hatalmas gázbuborékok emelkednek ki belőle és robbannak fel, rothadó hús szagával töltve be a levegőt. Tedd próbára SZERENCSED! Ha szerencsés vagy, lapozz a 192-re. Ha nincs szerencséd. lapozz a 188-ra.";
            currentIndex++;
            int choice32 = GetUserChoice32();
            if (choice32 == 192)
            {
                currentIndex = 192;
                SzovegList[188].Visible = false;
                SzovegList[181].Visible = false;
                SzovegList[192].Visible = true;
                SzovegList[192].Text = "#192\nSikerül gond nélkül elérned a túloldalt, majd sietve távozol az északi nyíláson át. Lapozz az 52-re.";
                currentIndex++;
                int choice33 = GetUserChoice33();
                if (choice33 == 52)
                {
                    currentIndex = 52;
                    SzovegList[192].Visible = false;
                    SzovegList[52].Visible = true;
                    SzovegList[52].Text = "#52\nA járat élesen keletre fordul, és végül egy ajtóba torkollik. Lapozz a 45-re.";
                    currentIndex++;
                    int choice34 = GetUserChoice34();
                    if (choice34 == 45)
                    {
                        currentIndex = 45;
                        SzovegList[52].Visible = false;
                        SzovegList[45].Visible = true;
                        SzovegList[45].Text = "#45\nHa be akarsz nyitni az ajtón, lapozz a 90-re. Ha tovább mennél keleti irányba, lapozz a 16-ra.";
                        currentIndex++;
                        int choice35 = GetUserChoice35();
                        if (choice35 == 90)
                        {
                            currentIndex = 90;
                            SzovegList[45].Visible = false;
                            SzovegList[90].Visible = true;
                            SzovegList[90].Text = "#90\nAz ajtón benyitva vaksötét fogad. Ha szeretnél végigtapogatózni a sötétben, lapozz a 167-re. Ha inkább távoznál innen, lapozz a 154-re.";
                            currentIndex++;
                            int choice36 = GetUserChoice36();
                            if (choice36 == 167)
                            {
                                currentIndex = 167;
                                SzovegList[90].Visible = false;
                                SzovegList[167].Visible = true;
                                SzovegList[167].Text = "#167\nRajtad van az Ügyesség Gyürüje? Ha igen, lapozz a 134-re. Ha nincs, lapozz az 58-ra.";
                                currentIndex++;
                                int choice37 = GetUserChoice37();
                                if (choice37 == 134)
                                {
                                    currentIndex = 134;
                                    SzovegList[167].Visible = false;
                                    SzovegList[134].Visible = true;
                                    SzovegList[134].Text = "#134\nValamennyi mágia még van a Gyürüdben, ami figyelmeztet, hogy a szoba átkutatása előtt próbálj meg meggyőződni arról, hogy nincs-e benne csapda. Sikerül kitapogatnod egy alig észrevehető, hajszálvékony rést a köpadlóban, ezért úgy döntesz, nem kockáztatod meg, hogy belépj. Lapozz a 154-re.";
                                    currentIndex++;
                                    int choice38 = GetUserChoice38();
                                    if (choice38 == 154)
                                    {
                                        currentIndex = 154;
                                        SzovegList[134].Visible = false;
                                        SzovegList[154].Visible = true;
                                        SzovegList[154].Text = "#154\nBezárod magad mögött az ajtót és tovább mész kelet felé. Lapozz a 16-ra.";
                                        currentIndex++;
                                        int choice39 = GetUserChoice39();
                                        if (choice39 == 16)
                                        {
                                            currentIndex = 16;
                                            SzovegList[154].Visible = false;
                                            SzovegList[16].Visible = true;
                                            SzovegList[16].Text = "#16\nAhogy előre haladsz, elkerüli figyelmedet egy medvecsapda. Belelépsz, fogai mélyen a lábadba marnak. Vesztesz. 2 ÉLETERŐ pontot. Valamivel később egy elágazáshoz érkezel. Úgy döntesz, a három lehetséges irány közül észak felé indulsz. Lapozz a 195-re.";
                                            currentIndex++;
                                            int choice40 = GetUserChoice40();
                                            if (choice40 == 195)
                                            {
                                                currentIndex = 195;
                                                SzovegList[16].Visible = false;
                                                SzovegList[195].Visible = true;
                                                SzovegList[195].Text = "#195\nA járatot egy hatalmas tölgyfa ajtó zárja el, melyen gyönyörűen megmunkált csuklópántok és egy hatalmas, sodort fémkilincs van. Két oldalán fáklyák égnek, melyek táncoló fénybe borítják az alagút ezen részét. Egy pergamenlapot látsz az ajtóra szögezve, amin több nyelven is egy szöveg olvasható. Gyorsan keresel egy olyat, amit te is megértesz. A szöveg a következő:\r\nHa idáig eljutottál igen båtor lehetsz. Bátorságod most vagy életet hoz rád, vagy halált. Kopogj és lépj be.\r\nBekopogsz az ajtón, és elfordítod a kilincset. Lapozz a 39-re.";
                                                currentIndex++;
                                                int choice41 = GetUserChoice41();
                                                if (choice41 == 39)
                                                {
                                                    currentIndex = 39;
                                                    SzovegList[195].Visible = false;
                                                    SzovegList[39].Visible = true;
                                                    SzovegList[39].Text = "#39\nA szobába belépve az eddig látott legcivilizáltabb teremben találod magad. A falakat fa burkolólapok borítják, fáklyák helyett itt egy lágy fényt árasztó gömb biztosítja a világítást, mely a szoba közepén álló asztal felett lebeg. E mellett egy férfi görnyedt alakját veszed észre. Miközben becsukod magad mögött az ajtót, az öregember felemelkedik, és üdvözlően feléd nyújtja mindkét karját. Hangja vékony és remegő, és csak ekkor jössz rá, mennyire vén is lehet. Megtaláltad a Szobrot? kérdezi tőled. Ha nálad van a tárgy, lapozz a 91-re. Ha nincs nálad, lapozz a 131-re. Ha nem bizol meg benne és rá akarsz támadni, lapozz a 77-re.";
                                                    currentIndex++;
                                                }
                                            }
                                        }

                                    }
                                }else if (choice37 == 58)
                                {
                                    currentIndex = 58;
                                    SzovegList[167].Visible = false;
                                    SzovegList[58].Visible = true;
                                    SzovegList[58].Text = "#58\n";
                                    currentIndex++;
                                }
                            }else if (choice36 == 154)
                            {
                                currentIndex = 154;
                                SzovegList[90].Visible = false;
                                SzovegList[154].Visible = true;
                                SzovegList[154].Text = "#154\n";
                                currentIndex++;
                            }
                        }else if (choice35 == 16)
                        {
                            currentIndex = 16;
                            SzovegList[45].Visible = false;
                            SzovegList[16].Visible = true;
                            SzovegList[16].Text = "#16\n";
                            currentIndex++;
                        }
                    }
                }
            }else if (choice32 == 188)
            {
                currentIndex = 188;
                SzovegList[181].Visible = false;
                SzovegList[188].Visible = true;
                SzovegList[188].Text ="#188\n";
                currentIndex++;
            }
        }
        private void Tovabb10_Click(object sender, EventArgs e)
        {
            tovabb10.Text = "Tovabb";
            tovabb10.Size = new Size(600, 75);
            tovabb9.Visible = false;
            tovabb11.Visible = false;
            SzovegList[161].Visible = false;
            SzovegList[181].Visible = false;
            SzovegList[193].Text = "#193\n";
            currentIndex++;
        }
        private void Tovabb11_Click(object sender, EventArgs e)
        {
            tovabb11.Text = "Tovabb";
            tovabb11.Size = new Size(600, 75);
            tovabb10.Visible = false;
            tovabb9.Visible = false;
            SzovegList[161].Visible = false;
            SzovegList[181].Visible = false;
            SzovegList[171].Text = "#171\n";
            currentIndex++;
        }
        private void Tovabb12_Click(object sender, EventArgs e)
        {

        }
        private void Tovabb13_Click(object sender, EventArgs e)
        {

        }
        private void Tovabb14_Click(object sender, EventArgs e)
        {

        }
        private int GetUserChoice()
        {
            DialogResult result108v147 = MessageBox.Show("Ha továbbra is északnak tartasz, lapozz a 108-ra.(IGEN)\nHa a nyugati irányba leágazó új járaton mennél tovább, lapozz a 147-re.(NEM)",
                                                  "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result108v147 == DialogResult.Yes)
            {
                return 108;
            }
            else if (result108v147 == DialogResult.No)
            {
                return 147;
            }
            return 108;
        }
        private int GetUserChoice2()
        {
            DialogResult result146v79 = MessageBox.Show("Hogyha egyenesen mész tovább, lapozz a 146 - ra.(IGEN)\n Ha letérsz jobbra, lapozz a 79-re.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result146v79 == DialogResult.Yes)
            {
                return 146;
            }
            else if (result146v79 == DialogResult.No)
            {
                return 79;
            }
            return 146;
        }
        private int GetUserChoice3()
        {
            DialogResult result51v80 = MessageBox.Show("Ha ki akarod nyitni az ajtót, lapozz az 51-re.(IGEN)\nHa letérsz jobbra, lapozz a 80-ra.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result51v80 == DialogResult.Yes)
            {
                return 51;
            }
            else if (result51v80 == DialogResult.No)
            {
                return 80;
            }
            return 51;
        }
        private int GetUserChoice4()
        {
            DialogResult result22v108 = MessageBox.Show("Hogyha ki szeretnéd nyitni, lapozz a 22-re.(IGEN)\nHa visszatérnél az elágazáshoz, és észak felé folytatnád az utad, lapozz a 108-ra.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result22v108 == DialogResult.Yes)
            {
                return 22;
            }
            else if (result22v108 == DialogResult.No)
            {
                return 108;
            }
            return 22;
        }
        private int GetUserChoice5()
        {
            DialogResult result146v79 = MessageBox.Show("Hogyha egyenesen mész tovább, lapozz a 146 - ra.(IGEN)\n Ha letérsz jobbra, lapozz a 79-re.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result146v79 == DialogResult.Yes)
            {
                return 146;
            }
            else if (result146v79 == DialogResult.No)
            {
                return 79;
            }
            return 146;
        }
        private int GetUserChoice6()
        {
            DialogResult result141v122 = MessageBox.Show("Ha erre mennél tovább, északi irányba, lapozz a 141-re.(IGEN)\nHa egyenesen folytatnád az utadat, lapozz a 122-re.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result141v122 == DialogResult.Yes)
            {
                return 141;
            }
            else if (result141v122 == DialogResult.No)
            {
                return 122;
            }
            return 141;
        }
        private int GetUserChoice7()
        {
            DialogResult result107v122 = MessageBox.Show("Ha ki szeretnéd nyitni és belépnél rajta, lapozz a 107-re.(IGEN)\nHa egyenesen folytatnád az utadat, lapozz a 122-re.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result107v122 == DialogResult.Yes)
            {
                return 107;
            }
            else if (result107v122 == DialogResult.No)
            {
                return 122;
            }
            return 107;
        }
        private int GetUserChoice8()
        {
            DialogResult result144 = MessageBox.Show("Tovább mersz haladni a 144-es mezőre?", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result144 == DialogResult.Yes)
            {
                return 144;
            }
            return 144;
        }
        private int GetUserChoice9()
        {
            DialogResult result144 = MessageBox.Show("Tovább mersz haladni a 144-es mezőre?", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result144 == DialogResult.Yes)
            {
                return 144;
            }
            return 144;
        }
        private int GetUserChoice10()
        {
            DialogResult result7v96 = MessageBox.Show("Ha szét akarsz nézni benne, lapozz a 7-re.(IGEN)\nHa inkább átugornád és kiderítenéd, mi a fényfolt forrása, lapozz a 96-ra.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result7v96 == DialogResult.Yes)
            {
                return 7;
            }else if (result7v96 == DialogResult.No)
            {
                return 96;
            }
            return 7;
        }
        private int GetUserChoice11()
        {
            DialogResult result80v140 = MessageBox.Show("Ha gyorsan kihátrálsz, majd becsapod magad mögött a bejárati ajtót, lapozz a 80-ra.(IGEN)\nHogyha megveted a lábad és megküzdesz ezekkel a szörnyű teremtményekkel, lapozz a 140-re.(NEM)", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result80v140 == DialogResult.Yes)
            {
                return 80;
            }else if (result80v140 == DialogResult.No)
            {
                return 140;
            }
            return 80;
        }
        private int GetUserChoice12()
        {
            DialogResult result89 = MessageBox.Show("Tovább mersz haladni a 89-es mezőre?", "Válassz egy irányt!", MessageBoxButtons.YesNo);

            if (result89 == DialogResult.Yes)
            {
                return 89;
            }
            return 89;
        }
        private int GetUserChoice13()
        {
            DialogResult result89 = MessageBox.Show("Tovább mersz haladni a 89-es mezőre?", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result89 == DialogResult.Yes)
            {
                return 89;
            }
            return 89;
        }
        private int GetUserChoice14()
        {
            DialogResult result95v127 = MessageBox.Show("Hogyha a nyugati ágon folytatnád az utad, lapozz a 95-re.(IGEN)\nHa egyenesen mész tovább, lapozz a 127-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result95v127 == DialogResult.Yes)
            {
                return 95;
            }else if (result95v127 == DialogResult.No)
            {
                return 127;
            }
            return 95;
        }
        private int GetUserChoice15()
        {
            DialogResult result153 = MessageBox.Show("Indulás a 153-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result153 == DialogResult.Yes)
            {
                return 153;
            }
            return 153;
        }
        private int GetUserChoice16()
        {
            DialogResult result42 = MessageBox.Show("Indulás a 42-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result42 == DialogResult.Yes)
            {
                return 42;
            }
            return 42;
        }
        private int GetUserChoice17()
        {
            DialogResult result27 = MessageBox.Show("Tovább mersz haladni a 27-es mezőre?", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result27 == DialogResult.Yes)
            {
                return 27;
            }
            return 27;
        }
        private int GetUserChoice18()
        {
            DialogResult result40v2 = MessageBox.Show("Ha az első megoldást választod, lapozz a 40-re.(IGEN)\nHa úgy gondolod, elég jó úszó vagy, és ezzel próbálkoznál, lapozz a 2-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result40v2 == DialogResult.Yes)
            {
                return 40;
            }
            else if (result40v2 == DialogResult.No)
            {
                return 2;
            }
            return 40;
        }
        private int GetUserChoice19()
        {
            DialogResult result60v75 = MessageBox.Show("Ha szerencsés vagy, lapozz a 60-ra.(IGEN)\nHa nem, lapozz a 75-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result60v75 == DialogResult.Yes)
            {
                return 60;
            }
            else if (result60v75 == DialogResult.No)
            {
                return 75;
            }
            return 60;
        }
        private int GetUserChoice20()
        {
            DialogResult result76 = MessageBox.Show("Indulás a 76-os mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

                if (result76 == DialogResult.Yes)
                {
                    return 76;
                }
                return 76;
        }
        private int GetUserChoice21()
        {
            DialogResult result13v121 = MessageBox.Show("Ha van nálad egy Arany Kulcs, lapozz a 13-ra.(IGEN)\nHa nincsen, lapozz a 121-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result13v121 == DialogResult.Yes)
            {
                return 13;
            }
            else if (result13v121 == DialogResult.No)
            {
                return 121;
            }
            return 13;
        }
        private int GetUserChoice22()
        {
            DialogResult result196 = MessageBox.Show("Indulás a 196-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result196 == DialogResult.Yes)
            {
                return 196;
            }
            return 196;
        }
        private int GetUserChoice23()
        {
            DialogResult result61 = MessageBox.Show("Indulás a 61-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result61 == DialogResult.Yes)
            {
                return 61;
            }
            return 61;
        }
        private int GetUserChoice24()
        {
            DialogResult result172v168 = MessageBox.Show("Ha észak felé akarsz fordulni, lapozz a 172-re.(IGEN)\nHa nem akarsz letérni ebből a járatból. lapozz a 168-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result172v168 == DialogResult.Yes)
            {
                return 172;
            }
            else if (result172v168 == DialogResult.No)
            {
                return 168;
            }
            return 172;
        }
        private int GetUserChoice25()
        {
            DialogResult result185v168 = MessageBox.Show("Ha most le akarsz itt ugrani, lapozz a 185-re.(IGEN)\n Ha inkább visszatérnél a korábban látott elágazáshoz és nyugat felé folytatnád az utad, lapozz a 168-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result185v168 == DialogResult.Yes)
            {
                return 185;
            }else if (result185v168 == DialogResult.No)
            {
                return 168;
            }
            return 185;
        }
        private int GetUserChoice26()
        {
            DialogResult result178v172 = MessageBox.Show("Ha alaposabban is szét akarsz odabenn nézni, úgy lapozz a 178-ra.(IGEN)\nHa inkább visszatérnél a szobába, lapozz a 172-re és válassz valami mást.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result178v172 == DialogResult.Yes)
            {
                return 178;
            }else if (result178v172 == DialogResult.No)
            {
                return 172;
            }
            return 178;
        }
        private int GetUserChoice27()
        {
            DialogResult result34 = MessageBox.Show("Indulás a 34-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result34 == DialogResult.Yes)
            {
                return 34;
            }
            return 34;
        }
        private int GetUserChoice28()
        {
            DialogResult result102v169 = MessageBox.Show("Ha meg akarod inni, lapozz a 102-re.(IGEN)\nHa inkább hagyod, ahol van, lapozz a 169-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result102v169 == DialogResult.Yes)
            {
                return 102;
            }else if (result102v169 == DialogResult.No)
            {
                return 169;
            }
            return 102;
        }
        private int GetUserChoice29()
        {
            DialogResult result169 = MessageBox.Show("Indulás a 169-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result169 == DialogResult.Yes)
            {
                return 169;
            }
            return 169;
        }
        private int GetUserChoice30()
        {
            DialogResult result164v172 = MessageBox.Show("Ha ki akarod nyitni, lapozz a 164-re.(IGEN)\nHa inkább hagyod, ahol van, lapozz vissza a 172-re és válassz valami mást.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result164v172 == DialogResult.Yes)
            {
                return 164;
            }else if (result164v172 == DialogResult.No)
            {
                return 172;
            }
            return 164;
        }
        private int GetUserChoice31()
        {
            DialogResult result161v73 = MessageBox.Show("Ha észak felé mennél, lapozz a 161-re.(IGEN)\nHa továbbra is nyugati irányba haladnál, lapozz a 73-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result161v73 == DialogResult.Yes)
            {
                return 161;
            }else if (result161v73 == DialogResult.No)
            {
                return 73;
            }
            return 161;
        }
        private int GetUserChoice32() 
        {
            DialogResult result192v188 = MessageBox.Show("Ha szerencsés vagy, lapozz a 192-re.(IGEN)\nHa nincs szerencséd. lapozz a 188-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result192v188 == DialogResult.Yes)
            {
                return 192;
            }else if(result192v188 == DialogResult.No)
            {
                return 188;
            }
            return 192;
        }
        private int GetUserChoice33() 
        {
            DialogResult result52 = MessageBox.Show("Indulás a 52-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result52 == DialogResult.Yes)
            {
                return 52;
            }
            return 52;
        }
        private int GetUserChoice34() 
        {
            DialogResult result45 = MessageBox.Show("Indulás a 45-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result45 == DialogResult.Yes)
            {
                return 45;
            }
            return 45;
        }
        private int GetUserChoice35()
        { 
            DialogResult result90v16 = MessageBox.Show("Ha be akarsz nyitni az ajtón, lapozz a 90-re.(IGEN)\nHa tovább mennél keleti irányba, lapozz a 16-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if(result90v16 == DialogResult.Yes)
            {
                return 90;
            }else if(result90v16 == DialogResult.No)
            {
                return 16;
            }
            return 90;
        }
        private int GetUserChoice36()
        { 
            DialogResult result167v154 = MessageBox.Show("Ha szeretnél végigtapogatózni a sötétben, lapozz a 167-re.(IGEN)\nHa inkább távoznál innen, lapozz a 154-re(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result167v154 == DialogResult.Yes)
            {
                return 167;
            }else if (result167v154 == DialogResult.No)
            {
                return 154;
            }
            return 167;
        }
        private int GetUserChoice37()
        {
            DialogResult result134v58 = MessageBox.Show("Ha igen, lapozz a 134-re.(IGEN)\nHa nincs, lapozz az 58-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result134v58 == DialogResult.Yes)
            {
                return 134;
            }else if (result134v58 == DialogResult.No){
                return 58;
            }
            return 134;
        }
        private int GetUserChoice38()
        { 
            DialogResult result154 = MessageBox.Show("Indulás a 154-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result154 == DialogResult.Yes)
            {
                return 154;
            }
            return 154;
        }
        private int GetUserChoice39()
        {
            DialogResult result16 = MessageBox.Show("Indulás a 16-os mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result16 == DialogResult.Yes)
            {
                return 16;
            }
            return 16;
        }
        private int GetUserChoice40()
        { 
            DialogResult result195 = MessageBox.Show("Indulás a 195-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result195 == DialogResult.Yes)
            {
                return 195;
            }
            return 195;
        }
        private int GetUserChoice41()
        { 
            DialogResult result39 = MessageBox.Show("Indulás a 39-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result39 == DialogResult.Yes) 
            {
                return 39;
            }
            return 39;
        }
        private int GetUserChoice42()
        {
            DialogResult result81v108 = MessageBox.Show("Ha megpróbálsz csendben átlopózni a helyiségen, lapozz a 81-re.(IGEN)\nHa semmiképp nem akarod felkelteni a kutyát, és az ajtó becsukása után inkább visszatérnél az elágazáshoz, hogy észak felé folytasd az utad. lapozz a 108-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result81v108 == DialogResult.Yes)
            {
                return 81;
            }
            return 81;
        }
        private int GetUserChoice43()
        {
            DialogResult result97v138 = MessageBox.Show("Ha szerencsés vagy, lapozz a 97-re.(IGEN)\nHa nincs szerencséd, lapozz a 138-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result97v138 == DialogResult.Yes)
            {
                return 97;
            }else if (result97v138 == DialogResult.No)
            {
                return 138;
            }
            return 97;
        }
        private int GetUserChoice44()
        {
            DialogResult result30 = MessageBox.Show("Indulás a 30-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result30 == DialogResult.Yes)
            {
                return 30;
            }
            return 30;
        }
        private int GetUserChoice45()
        {
            DialogResult result100 = MessageBox.Show("Indulás a 100-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result100 == DialogResult.Yes)
            {
                return 100;
            }
            return 100;
        }
        private int GetUserChoice46()
        {
            DialogResult result30 = MessageBox.Show("Indulás a 30-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result30 == DialogResult.Yes)
            {
                return 30;
            }
            return 30;
        }
        private int GetUserChoice47()
        {
            DialogResult result124v129 = MessageBox.Show("Ha be akarsz nyitni rajta, lapozz a 124-re.(IGEN)\nHa a folyosón folytatnád az utad, lapozz a 129-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result124v129 == DialogResult.Yes)
            {
                return 124;
            }else if (result124v129 == DialogResult.No)
            {
                return 129;
            }
            return 124;
        }
        private int GetUserChoice48()
        {
            DialogResult result124v129 = MessageBox.Show("Ha be akarsz nyitni rajta, lapozz a 124-re.(IGEN)\nHa a folyosón folytatnád az utad, lapozz a 129-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result124v129 == DialogResult.Yes)
            {
                return 124;
            }else if (result124v129 == DialogResult.No)
            {
                return 129;
            }
            return 124;
        }
        private int GetUserChoice49()
        {
            DialogResult result129v64 = MessageBox.Show("Hogyha elhagyod a helyiséget és folytatod az utadat, lapozz a 129-re.(IGEN)\nHa leereszkedsz az alsóbb szintre, és ott mész tovább, lapozz a 64-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result129v64 == DialogResult.Yes)
            {
                return 129;
            }else if (result129v64 == DialogResult.No)
            {
                return 64;
            }
            return 129;
        }
        private int GetUserChoice50()
        {
            DialogResult result112v66 = MessageBox.Show("Ha kelet felé mennél tovább. lapozz a 112-re.(IGEN)\nHogyha északnak folytatnád az utad, lapozz a 66-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result112v66 == DialogResult.Yes)
            {
                return 112;
            }else if (result112v66 == DialogResult.No)
            {
                return 66;
            }
            return 112;
        }
        private int GetUserChoice51()
        {
            DialogResult result112v66 = MessageBox.Show("Ha kelet felé mennél tovább. lapozz a 112-re.(IGEN)\nHogyha északnak folytatnád az utad, lapozz a 66-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result112v66 == DialogResult.Yes)
            {
                return 112;
            }else if (result112v66 == DialogResult.No)
            {
                return 66;
            }
            return 112;
        }
        private int GetUserChoice52()
        {
            DialogResult result117v186 = MessageBox.Show("Ha szerencséd van, lapozz a 117-re.(IGEN)\nHogyha nincs szerencséd, lapozz a 186-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result117v186 == DialogResult.Yes)
            {
                return 117;
            }else if (result117v186 == DialogResult.No)
            {
                return 186;
            }
            return 117;
        }
        private int GetUserChoice53()
        {
            DialogResult result118 = MessageBox.Show("Indulás a 118-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result118 == DialogResult.Yes)
            {
                return 118;
            }
            return 118;
        }
        private int GetUserChoice54()
        {
            DialogResult result187v156 = MessageBox.Show("Hogyha megmondod neki, lapozz a 187-re.(IGEN)\nHa rossz utat mondasz neki, lapozz a 156-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result187v156 == DialogResult.Yes)
            {
                return 187;
            }else if (result187v156 == DialogResult.No)
            {
                return 156;
            }
            return 187;
        }
        private int GetUserChoice55()
        {
            DialogResult result145 = MessageBox.Show("Indulás a 145-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result145 == DialogResult.Yes)
            {
                return 145;
            }
            return 145;
        }
        private int GetUserChoice56()
        {
            DialogResult result145 = MessageBox.Show("Indulás a 145-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result145 == DialogResult.Yes)
            {
                return 145;
            }
            return 145;
        }
        private int GetUserChoice57()
        {
            DialogResult result98 = MessageBox.Show("Indulás a 98-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result98 == DialogResult.Yes)
            {
                return 98;
            }
            return 98;
        }
        private int GetUserChoice58()
        {
            DialogResult result44v8 = MessageBox.Show("Ha a szerencsés vagy, lapozz a 44-re.(IGEN)\nHa nincs szerencséd, lapozz a 8-ra.", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result44v8 == DialogResult.Yes)
            {
                return 44;
            }
            else if (result44v8 == DialogResult.No)
            {
                return 8;
            }
            return 44;
        }
        private int GetUserChoice59()
        {
            DialogResult result44v8 = MessageBox.Show("Ha a szerencsés vagy, lapozz a 44-re.(IGEN)\nHa nincs szerencséd, lapozz a 8-ra.", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result44v8 == DialogResult.Yes)
            {
                return 44;
            }
            else if (result44v8 == DialogResult.No)
            {
                return 8;
            }
            return 44;
        }
        private int GetUserChoice60()
        {
            DialogResult result65 = MessageBox.Show("Indulás a 65-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result65 == DialogResult.Yes)
            {
                return 65;
            }
            return 65;
        }
        private int GetUserChoice61()
        {
            DialogResult result65 = MessageBox.Show("Indulás a 65-ös mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result65 == DialogResult.Yes)
            {
                return 65;
            }
            return 65;
        }
        private int GetUserChoice62()
        {
            DialogResult result84 = MessageBox.Show("Indulás a 84-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result84 == DialogResult.Yes)
            {
                return 84;
            }
            return 84;
        }
        private int GetUserChoice63()
        {
            DialogResult result157v125 = MessageBox.Show("Ha be szeretnél nyitni. lapozz a 157-re.(IGEN)\nHa úgy gondolod, ez túl nyilvánvaló megoldás lenne és tovább mennél észak felé, lapozz a 125-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);

            if (result157v125 == DialogResult.Yes)
            {
                return 157;
            }else if (result157v125 == DialogResult.No)
            {
                return 125;
            }
            return 157;
        }
        private int GetUserChoice64()
        {
            DialogResult result142 = MessageBox.Show("Indulás a 142-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result142 == DialogResult.Yes)
            {
                return 142;
            }
            return 142;
        }
        private int GetUserChoice65()
        {
            DialogResult result127 = MessageBox.Show("Indulás a 127-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result127 == DialogResult.Yes)
            {
                return 127;
            }
            return 127;
        }
        private int GetUserChoice66()
        {
            DialogResult result81v108 = MessageBox.Show("Ha megpróbálsz csendben átlopózni a helyiségen, lapozz a 81-re.(IGEN)\nHa semmiképp nem akarod felkelteni a kutyát, és az ajtó becsukása után inkább visszatérnél az elágazáshoz, hogy észak felé folytasd az utad. lapozz a 108-ra.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result81v108 == DialogResult.Yes)
            {
                return 81;
            }else if (result81v108 == DialogResult.No)
            {
                return 108;
            }
            return 81;
        }
        private int GetUserChoice67()
        {
            DialogResult result146v79 = MessageBox.Show("Indulás a 81-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result146v79 == DialogResult.Yes)
            {
                return 146;
            }else if (result146v79 == DialogResult.No)
            {
                return 79;
            }
            return 146;
        }
        private int GetUserChoice68()
        {
            DialogResult result40v2 = MessageBox.Show("Ha az első megoldást választod, lapozz a 40-re.(IGEN)\nHa úgy gondolod, elég jó úszó vagy, és ezzel próbálkoznál, lapozz a 2-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result40v2 == DialogResult.Yes)
            {
                return 40;
            }else if (result40v2 == DialogResult.No)
            {
                return 2;
            }
            return 40;
        }
        private int GetUserChoice69()
        {
            DialogResult result165v96 = MessageBox.Show("165-IGEN\n96-NEM", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result165v96 == DialogResult.Yes)
            {
                return 165;
            }else if (result165v96 == DialogResult.No)
            {
                return 96;
            }
            return 165;
        }
        private int GetUserChoice70()
        {
            DialogResult result148 = MessageBox.Show("Indulás a 148-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result148 == DialogResult.Yes)
            {
                return 148;
            }
            return 148;
        }
        private int GetUserChoice71()
        {
            DialogResult result198 = MessageBox.Show("Indulás a 198-as mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result198 == DialogResult.Yes)
            {
                return 198;
            }
            return 198;
        }
        private int GetUserChoice72()
        {
            DialogResult result49v152 = MessageBox.Show("Ha elég éhes vagy ahhoz, hogy megedd, vagy úgy sejted, valamilyen mágikus tulajdonsággal rendelkezik, lapozz a 49-re.(IGEN)\nHa inkább hagyod, ahol van és az északi ajtón át távozol, lapozz a 152-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
       
            if (result49v152 == DialogResult.Yes)
            {
                return 49;
            }else if (result49v152 == DialogResult.No)
            {
                return 152;
            }
            return 49;
        }
        private int GetUserChoice73()
        {
            DialogResult result99= MessageBox.Show("Indulás a 99-es mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            
            if (result99 == DialogResult.Yes)
            {
                return 99;
            }
            return 99;
        }
        private int GetUserChoice74()
        {
            DialogResult result87v6 = MessageBox.Show("Ha az északi ajtón át távoznál, lapozz a 87-re.(IGEN)\nHa a nyugatin lépnél be, lapozz a 6-ra(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result87v6 == DialogResult.Yes)
            {
                return 87;
            }else if (result87v6 == DialogResult.No)
            {
                return 6;
            }
            return 87;
        }
        private int GetUserChoice75()
        {
            DialogResult result13v121 = MessageBox.Show("Ha legalább 5 ÉLETERŐD van, lapozz a 13-ra.(IGEN)\nHa nincsen, lapozz a 121-re.(NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result13v121 == DialogResult.Yes)
            {
                return 13;
            }else if (result13v121 == DialogResult.No)
            {
                return 121;
            }
            return 13;
        }
        private int GetUserChoice76()
        {
            DialogResult result6 = MessageBox.Show("Indulás a 6-os mezőre!(IGEN/NEM)", "Válaszolj!", MessageBoxButtons.YesNo);
            if (result6 == DialogResult.Yes)
            {
                return 6;
            }
            return 6;
        }
        private void BetorAjto()
        {
            Random rand = new Random();
            int kockaErtek = rand.Next(1, 7);

            if (kockaErtek >= 1 && kockaErtek <= 4)
            {
                MessageBox.Show("Megsérültél és vesztesz 2 ÉLETERŐ pontot.");
                playerStats.Hp -= 2;
                playerhp.Text = $"Hp:{playerStats.Hp}";
            }
            else if (kockaErtek >= 5 && kockaErtek <= 6)
            {
                MessageBox.Show("Sikerült betörnöd az ajtót. Lapozz a 158-ra.");
                currentIndex = 158;
            }

            if (kockaErtek < 5)
            {
                BetorAjto();
            }
        }
        private void FulladasSkip()
        {
            Random random = new Random();
            int kockaErtek1 = random.Next(1, 7);
            int kockaErtek2 = random.Next(1, 7);
            int osszKockaErtek = kockaErtek1 + kockaErtek2;

            MessageBox.Show("Csaknem megfulladsz, de kitartasz. Dobj két kockával. Az eredmény: " + osszKockaErtek);

            if (osszKockaErtek <= playerStats.Skill)
            {
                MessageBox.Show("Az eredmény kevesebb vagy ugyanannyi, mint UGYESSÉG pontjaid száma. Lapozz a 103-ra.");
                currentIndex = 103;
            }
            else
            {
                MessageBox.Show("Az eredmény nagyobb, mint UGYESSÉG pontjaid száma. Lapozz a 15-re.");
                currentIndex = 15;
            }
        }
        private void ShowGameOver()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("gameover.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("Game Over!", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowGameOver111()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("gameover.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("Az alagút egyre szűkösebb lesz, és ahogy próbálsz előre haladni, a falak szorítani kezdenek. Légzésed nehezedik, és bár mindent megpróbálsz, egyszerűen már nem tudsz mozdulni. A körülötted lévő sötétség elnyel, és minden remény elveszik.", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowGameOver49()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("gameover.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("A növénykének valóban különleges ereje volt – ám ahogy az utazó mohón felfalja, gyomrában lassan hideg borzongás fut végig.Egy pillanattal később lábai elgyengülnek, látása elhomályosul… majd teste élettelenül rogy a földre.", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowGameOver99()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("gameover.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("A fáklyák halovány fényében megpillantod a padlón kígyózó árnyakat – ám mielőtt reagálhatnál, jeges fájdalom hasít beléd. Csapdába léptél. A padló kattanva megnyílik alattad, és sikoltva zuhansz a feneketlen mélységbe.", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowGameOver121()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("gameover.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("Nincs más választásod, minthogy a válladdal ronts neki az ajtónak. Nem lesz egy egyszerű feladat, mivel a szegecsek igen hosszúak és hegyesek. Első neki futásra megsérűlsz majd a hirtelen vérvezteségbe bele halsz!", "Vesztettél!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void ShowWin()
        {
            this.Controls.Clear();
            this.BackgroundImage = null;
            this.BackgroundImage = Image.FromFile("Win.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show("Az ajtót kinyitva meglátsz egy pázsitot és hátra nézve össze omlik a labirintus, gyorsan átmész az ajtón és rá eszmélsz, hogy sikeresen kijutottál az ÍTÉLET LABIRINTUSÁBÓL!", "Nyertél!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }
        private void Tolvaj(int enemySkill, int enemyStamina)
        {
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("Tolvaj.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: "+ playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250,250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Image ekko = new Bitmap("ekko.png");
            ekkovek.Image = ekko;
            ekkovek.ImageAlign = ContentAlignment.TopLeft;

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina <= 0)
                {
                    continue;
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    Coins.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    ekkovek.Visible = false;
                    elelmiszer.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[87].Visible = true;
                    tovabb.Visible = true;
                    italok.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    felszereles.Visible = true;
                    felszereles2.Visible = true;
                    ekkovek.Visible = true;
                    elelmiszer.Visible = true;
                    Coins.Visible = true;
                    Coins.Text =$"Coins:{playerStats.Coins+3}";
                    Nyeremeny.Visible = true;
                    Nyeremeny.Text = $"3 Coint kaptál";
                    playerhp.Text =$"Hp:{playerStats.Hp}";
                    
                    return;
                }
            }
        }
        private void Suni(int enemySkill, int enemyStamina)
        {
            SzovegList[153].Visible = false;
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("Suni.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: " + playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Image husi = new Bitmap("husi.png");
            elelmiszer.Image = husi;
            elelmiszer.ImageAlign = ContentAlignment.TopLeft;

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina <= 0)
                {
                    continue;
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    Coins.Visible = false;
                    elelmiszer.Visible = false;
                    ekkovek.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[153].Visible = true;
                    SzovegList[153].Text = "#153\nMivel a tüskék nagyon mérgezőek, valahányszor beléd áll valamelyik, a szokásos 2 helyett 3 ÉLETERŐ pontot kell levonnod magadtól. Lapozz a 42-re.";
                    tovabb.Visible = true;
                    italok.Visible = true;
                    felszereles.Visible = true;
                    felszereles2.Visible = true;
                    elelmiszer.Visible = true;
                    ekkovek.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    Coins.Visible = true;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    return;
                }
            }
        }
        private void Galon(int enemySkill, int enemyStamina)
        {
            SzovegList[158].Visible = false;
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("Ork.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: " + playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina >= 0)
                {
                    ShowGameOver();
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    Coins.Visible = false;
                    elelmiszer.Visible = false;
                    ekkovek.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[158].Visible = true;
                    SzovegList[158].Text = "#153\nHa nyertél, lapozz a 61-re.";
                    tovabb.Visible = true;
                    italok.Visible = true;
                    felszereles.Visible=true;
                    felszereles2.Visible=true;
                    elelmiszer.Visible = true;
                    ekkovek.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    Coins.Visible = true;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    return;
                }
            }
            ShowGameOver();
        }
        private void Xlaia(int enemySkill, int enemyStamina)
        {
            SzovegList[138].Visible = false;
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("Xlaia.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: " + playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina >= 0)
                {
                    ShowGameOver();
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    Coins.Visible = false;
                    elelmiszer.Visible = false;
                    ekkovek.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[138].Visible = true;
                    SzovegList[138].Text = "#138\nHa végzel vele, lapozz a 100-ra.";
                    tovabb.Visible = true;
                    italok.Visible = true;
                    felszereles.Visible=true;
                    felszereles2.Visible=true;
                    elelmiszer.Visible = true;
                    ekkovek.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    Coins.Visible = true;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    return;
                }
            }
        }
        private void torpe(int enemySkill, int enemyStamina)
        {
            SzovegList[66].Visible = false;
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("torpe.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: " + playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina >= 0)
                {
                    ShowGameOver();
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    Coins.Visible = false;
                    elelmiszer.Visible = false;
                    ekkovek.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[66].Visible = true;
                    SzovegList[66].Text = "#66\nHa győzöl, északi irányba folytatod az utad, lefelé a lépcsőn. Lapozz a 118-ra.";
                    tovabb.Visible = true;
                    italok.Visible = true;
                    felszereles.Visible=true;
                    felszereles2.Visible=true;
                    elelmiszer.Visible = true;
                    ekkovek.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    Coins.Visible = true;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    return;
                }
            }
        }
        private void Ork(int enemySkill, int enemyStamina)
        {
            SzovegList[107].Visible = false;
            Player = new PictureBox()
            {
                Image = Image.FromFile("Player.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 650),
            };
            Controls.Add(Player);

            Enemy = new PictureBox()
            {
                Image = Image.FromFile("Ork.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Size = new Size(200, 350),
                Location = new Point(885, 65),
            };
            Controls.Add(Enemy);

            playerhp = new Label()
            {
                Text = "Hp: " + playerStats.Hp.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 620),
                Visible = true

            };
            Controls.Add(playerhp);

            enemyhp = new Label()
            {
                Text = "Hp: " + enemyStamina.ToString(),
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup,
                Size = new Size(250, 250),
                Location = new Point(910, 430),
                Visible = true

            };
            Controls.Add(enemyhp);
            this.BackgroundImage = Image.FromFile("fightscene.png");

            Random rand = new Random();
            int playerStamina = playerStats.Hp;

            while (enemyStamina > 0 && playerStamina > 0)
            {
                int enemyAttack = enemySkill + rand.Next(1, 7) + rand.Next(1, 7);
                int playerAttack = playerStats.Skill + rand.Next(1, 7) + rand.Next(1, 7);

                if (playerAttack > enemyAttack)
                {
                    enemyStamina -= 2;
                }
                else if (enemyAttack > playerAttack)
                {
                    playerStamina -= 2;
                }

                if (playerStamina >= 0)
                {
                    ShowGameOver();
                }
                else if (enemyStamina <= 0)
                {
                    SzovegList[1].Visible = false;
                    tovabb.Visible = false;
                    italok.Visible = false;
                    hp.Visible = false;
                    stamina.Visible = false;
                    luck.Visible = false;
                    felszereles.Visible = false;
                    felszereles2.Visible = false;
                    elelmiszer.Visible = false;
                    ekkovek.Visible = false;
                    Coins.Visible = false;
                    MessageBox.Show("Győztél!", "Siker", MessageBoxButtons.OK);
                    this.BackgroundImage = Image.FromFile("bg.png");
                    Enemy.Visible = false;
                    Player.Visible = false;
                    playerhp.Visible = false;
                    enemyhp.Visible = false;
                    SzovegList[107].Visible = true;
                    SzovegList[107].Text = "#66\nHa legyőzöd ellenfeleidet, lapozz a 198-ra.";
                    tovabb.Visible = true;
                    italok.Visible = true;
                    felszereles.Visible = true;
                    felszereles2.Visible = true;
                    elelmiszer.Visible = true;
                    ekkovek.Visible = true;
                    hp.Visible = true;
                    stamina.Visible = true;
                    luck.Visible = true;
                    Coins.Visible = true;
                    playerhp.Text = $"Hp:{playerStats.Hp}";
                    return;
                }
            }
        }
    }
}