using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectGameMVC
{
    public partial class Game : Form
    {
        public bool flaggcon = false;
        //khoi tao 
        public static Button[,] arrMap = new Button[10, 10];
        public static Button[] health = new Button[10];
        public static List<Button> ListQuestion = new List<Button>();


        //set dia chi lay file anh co dinh
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        // set vị trí ban đầu
        Point charater = new Point { X = 1, Y = 1 };
        Point monster = new Point { X = 8, Y = 8 };

        //set 1 vai thong so
        int timeSec = 0;
        int timeMin = 0;
        int curHealth = health.Length - 1;


        public Game()
        {
            InitializeComponent();
            readMap();


        }



        public void readMap()
        {
            panelMain.BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\map.jpg"));
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelHero.BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\LayoutHero.jpg"));
            panelHero.BackgroundImageLayout = ImageLayout.Stretch;
            panelBoss.BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\LayoutBoss.jpg"));
            panelBoss.BackgroundImageLayout = ImageLayout.Stretch;

            int btnSize = panelMain.Height / 10;   //lấy size cho btn 

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                    // tạo btn và đặt size cho nó         
                    arrMap[i, j] = new Button();
                    arrMap[i, j].Height = btnSize;
                    arrMap[i, j].Width = btnSize;

                    //chuyển background sang trong suốt
                    arrMap[i, j].FlatStyle = FlatStyle.Flat;
                    arrMap[i, j].BackColor = Color.Transparent;
                    arrMap[i, j].FlatAppearance.MouseDownBackColor = Color.Transparent;
                    arrMap[i, j].FlatAppearance.MouseOverBackColor = Color.White;

                    //add vào panel
                    panelMain.Controls.Add(arrMap[i, j]);
                    //Set value vị trí cho btn 
                    arrMap[i, j].Location = new Point(i * btnSize, j * btnSize);
                    arrMap[i, j].Tag = new Point(i, j);

                    //gán thêm sự kiện cho btn
                    arrMap[i, j].Click += btn_Click;



                }


            }
            setCharater(1, 1);//cài đặt vị trí ảnh trùng với Point nhân vật 
            setMonster(8, 8); // tương tự với boss
            CreateHealth(); // vẽ 10 ô máu cho boss
            btnQuestion(); //tạo câu hỏi random (5 câu )
            timer1.Start(); //Vẽ xong mọi thứ r tính tgian chơi

        }


        private void backColorBtn(Button btn)
        {
            btn.BackgroundImage = null; //gán null thì mới đè ảnh khác lên đc hoặc chuyển btn về Transparent (trong suốt)
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button clickBtn = (Button)sender; // khai báo


            Point location = (Point)clickBtn.Tag;  // Lấy địa chỉ x y của btn bấm 
            int x = location.X;
            int y = location.Y;



            if (x == charater.X && y == charater.Y)      // ktra lần đầu bấm có p Chararer hay k ?
            {
                Check(x, y);                        // Kiểm tra các vị trí có thể đi đc


            }
            else if (clickBtn.Text == "GO")            //Nếu k phải là charater mà btn đó có text = Go thì cho đi 
            {

                backColorBtn(arrMap[charater.X, charater.Y]);   //chuyẻn lại màu cho btn trc đó 
                                                                // lấy vị trí btn mới bấm
                charater.X = x;
                charater.Y = y;

                //Cài lại vị  trí nhân vật
                setCharater(x, y);

                //tự động di chuyển boss khi nhân vật di chuyển 
                autoMoveMonster(x, y);
                //Ktra boss đụng dô hero chưa
                checkMove();
                //Ktra nếu là ô câu hỏi thì nhảy ra câu hỏi
                QuestionForm questionForm = new QuestionForm();

                if (ListQuestion.Contains(clickBtn))
                {

                    questionForm.Show();
                    if (questionForm.flagCon)
                    {
                        lossHealth();
                    }




                }


                //Khởi tạo lại text trong btn (tạo lại các vị trí đã đi đc 
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        arrMap[i, j].Text = "";  // gán text != GO thì bấm lại k đi đc

                    }
                }
            }
            else
            {
                MessageBox.Show("Oh no anh bạn à!!! Chọn sai đường rồi ");
            }

        }
        private void btn_Click2(object sender, EventArgs e)
        {

        }
        void btnQuestion()      //tạo btn chứa câu hỏi 
        {
            int Collumn = -1;
            int Row = -1;
            int countQues = 0; //số lượng câu hỏi 
            Random random = new Random();


            while (countQues < 5) //tạo 5 câu
            {
                Collumn = random.Next(1, 10);
                Row = random.Next(1, 10);
                if (Collumn != charater.X || Collumn != monster.X || Row != charater.Y || Row != monster.Y) // ktra khác câu hỏi tạo ra phải khác vị trí của hero và boss 
                {
                    arrMap[Collumn, Row].BackgroundImage = null;
                    arrMap[Collumn, Row].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\question.jpg"));
                    arrMap[Collumn, Row].BackgroundImageLayout = ImageLayout.Stretch;
                    //Thêm vô list những ô chứa câu hỏi 
                    ListQuestion.Add(arrMap[Collumn, Row]);
                }
                countQues++;
            }
        }


        void checkMove()            //ktra hero có  đụng  p boss hay k
        {
            if (charater.X == monster.X && charater.Y == monster.Y)
            {
                MessageBox.Show("Ohhh nooooo rớt môn r ");
                this.Close();
                MainMenuForm newgame = new MainMenuForm();
                newgame.Show();

            }

        }

        public void CreateHealth() //tạo máu cho 
        {

            int btnHealth = panelHealth.Width / 10; // lấy size cho btn
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button() { Width = btnHealth, Height = btnHealth };
                //style màu mè cho đẹp
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Red;
                btn.FlatAppearance.MouseDownBackColor = Color.Red;
                btn.FlatAppearance.MouseOverBackColor = Color.Red;
                //vị trí
                btn.Location = new Point(i * btnHealth);
                btn.BackColor = Color.Red;
                //Thêm vô arrHealth để xử lí khi mất máu
                health[i] = btn;
                //thêm vô panel
                panelHealth.Controls.Add(health[i]);

            }
        }



        public void lossHealth()   //Mất máu  && Ktra win chưa 
        {
            panelHealth.Controls.RemoveAt(curHealth);
            curHealth--;

            if (curHealth < 0)
            {
                MessageBox.Show("Endddddddddddddddddddddd!!! Ban da qua mon");
            }
        }



        //Hàm check bao gồm các trường hợp đặt biệt trong Hình vuông\
        //4 góc và 4 cạnh
        //còn lại đặt như nhau

        public void Check(int x, int y)
        {
            //Ngay góc     
            if (x == 0 && y == 0)
            {
                arrMap[x + 1, y].Text = "GO";

                arrMap[x, y + 1].Text = "GO";

            }
            else
            if (x == 9 && y == 9) //Góc
            {
                arrMap[x, y - 1].Text = "GO";

                arrMap[x - 1, y].Text = "GO";

            }
            else
            if (x == 0 && y == 9)    //Góc
            {
                arrMap[x + 1, y].Text = "GO";

                arrMap[x, y - 1].Text = "GO";

            }
            else
            if (x == 9 && y == 0)  // Góc
            {
                arrMap[x - 1, y].Text = "GO";

                arrMap[x, y + 1].Text = "GO";

            }


            else
            if (x == 0 & y > 0 & y < 9) //cạnh
            {
                arrMap[x + 1, y].Text = "GO";
                arrMap[x, y - 1].Text = "GO";

                arrMap[x, y + 1].Text = "GO";


            }
            else if (y == 0 & 0 < x & x < 9) //cạnh
            {

                arrMap[x + 1, y].Text = "GO";


                arrMap[x - 1, y].Text = "GO";

                arrMap[x, y + 1].Text = "GO";


            }
            else if (x == 9 & y > 0 & y < 9)   //cạnh
            {
                arrMap[x, y - 1].Text = "GO";


                arrMap[x, y + 1].Text = "GO";


                arrMap[x - 1, y].Text = "GO";


            }
            else if (y == 9 & x > 0 & x < 9) //cạnh
            {
                arrMap[x - 1, y].Text = "GO";


                arrMap[x + 1, y].Text = "GO";

                arrMap[x, y - 1].Text = "GO";


            }
            else    //Các trường hợp còn lại 
            {
                arrMap[x + 1, y].Text = "GO";


                arrMap[x, y + 1].Text = "GO";


                arrMap[x - 1, y].Text = "GO";



                arrMap[x, y - 1].Text = "GO";

            }



        }




        public Point setCharater(int x, int y)         //vi tri x y truyen
        {


            arrMap[charater.X, charater.Y].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\hero.jpg"));

            arrMap[charater.X, charater.Y].BackgroundImageLayout = ImageLayout.Stretch;


            return charater;
        }


        public Point setMonster(int x, int y)         //vi tri x y truyen
        {


            arrMap[monster.X, monster.Y].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\Boss.jpg"));

            arrMap[monster.X, monster.Y].BackgroundImageLayout = ImageLayout.Stretch;


            return monster;
        }


        //Ý tưởng: lấy x & y là vị trí Hero so sánh
        //          4 hướng : trên , dưới , trái , phải 
        //             +random cho chọn bất kì đi chiều ngang hoặc dọc
        //                    +đi dọc thì random lên hoặc xuống <=> đi ngang thì random trái hoặc phải
        public void autoMoveMonster(int x, int y)
        {
            Random rand = new Random();

            switch (rand.Next(1, 3))    //random 1 trong 2 trường hợp
            {
                case 1:     //đi dọc                                 
                    if (x >= monster.X && monster.X <= 9) // <9 trong giới hạn matran 
                    {
                        if (ListQuestion.Contains(arrMap[monster.X, monster.Y]))   //So vị trí hiện tại nếu là btn câu hỏi thì sau khi đi trả lại image câu hỏi
                        {
                            monster.X += 1;
                            setMonster(monster.X, monster.Y);
                            arrMap[monster.X - 1, monster.Y].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\question.jpg"));
                        }
                        else // không phải ô câu hỏi  thì đi trả lại ô trước đó là backgroundImage = null; 
                        {
                            monster.X += 1;
                            setMonster(monster.X, monster.Y);
                            backColorBtn(arrMap[monster.X - 1, monster.Y]);
                        }
                    }
                    else
                    if (x <= monster.X && monster.X >= 0)       //tương tự
                    {
                        if (ListQuestion.Contains(arrMap[monster.X, monster.Y]))
                        {
                            monster.X -= 1;
                            setMonster(monster.X, monster.Y);
                            arrMap[monster.X + 1, monster.Y].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\question.jpg"));
                        }
                        else
                        {
                            monster.X -= 1;
                            setMonster(monster.X, monster.Y);
                            backColorBtn(arrMap[monster.X + 1, monster.Y]);
                        }
                    }
                    break;
                case 2: //đi ngang
                    if (y >= monster.Y && monster.Y <= 9)
                    {
                        if (ListQuestion.Contains(arrMap[monster.X, monster.Y]))//ktra tương tự trên
                        {
                            monster.Y += 1;
                            setMonster(monster.X, monster.Y);
                            arrMap[monster.X, monster.Y - 1].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\question.jpg"));
                        }
                        else
                        {
                            monster.Y += 1;
                            setMonster(monster.X, monster.Y);
                            backColorBtn(arrMap[monster.X, monster.Y - 1]);
                        }
                    }
                    else
                    if (y <= monster.Y && monster.Y >= 0)  //ktra tương tự trên
                    {
                        if (ListQuestion.Contains(arrMap[monster.X, monster.Y]))
                        {
                            monster.Y -= 1;
                            setMonster(monster.X, monster.Y);
                            arrMap[monster.X, monster.Y + 1].BackgroundImage = Image.FromFile(Path.Combine(projectPath, @"Resources\question.jpg"));
                        }
                        else
                        {
                            monster.Y -= 1;
                            setMonster(monster.X, monster.Y);
                            backColorBtn(arrMap[monster.X, monster.Y + 1]);
                        }
                    }
                    break;
            }
        }

        //set tgian 
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSec++;
            lbSec.Text = timeSec.ToString() + "s";
            if (timeSec == 59)
            {
                timeSec = 0;
                timeMin++;
                lbMin.Text = timeMin.ToString() + "m";
            }
        }

        private void btnMoreQues_Click(object sender, EventArgs e)
        {
            if (ListQuestion.Count == 0)
            {
                btnQuestion();
            }
            else
            {
                MessageBox.Show("Nhớ trả lời hết câu hỏi bạn nhá ^^ \nĐừng vội bỏ cuộc !!! Tri thức là sức mạnh !!!");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbMin_Click(object sender, EventArgs e)
        {

        }


    }
}
