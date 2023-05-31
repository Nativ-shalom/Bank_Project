using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;



namespace BankProject3
{
    public partial class Form1 : Form
    {
        //LinkedList<Person> People = new LinkedList<Person>();

        //LinkedList<RegularWorker> regularWorkers = new LinkedList<RegularWorker>();
        //LinkedList<SeniorEmployee> seniorEmployees = new LinkedList<SeniorEmployee>();
        //LinkedList<Client> clients = new LinkedList<Client>();


        List<RegularWorker> regularWorkers = new List<RegularWorker>();
        List<SeniorEmployee> seniorEmployees = new List<SeniorEmployee>(); 
        List<Client> clients = new List<Client>();

        //-----------------------------------------------------------//
        //Client currclient = new Client(); /*= clients.First;*/
        //RegularWorker currRegWorker = new RegularWorker();
        //SeniorEmployee currSenEmploye = new SeniorEmployee();

        

        DataTable Table = new DataTable("Table");

        public Form1()
        {
            //firstClient();
            //firstRegWorker();
            //firstSenWorker();

            //regularWorkers.Add(currRegWorker);

            regularWorkers.Add(new RegularWorker("Alex", "Huzt", 24, "2212", 2, "Holon", 8500));
            regularWorkers.Add(new RegularWorker("Aviv", "Lvi", 31, "5614", 4, "Modien", 9000));
            regularWorkers.Add(new RegularWorker("Moshe", "Cohen", 26, "1577", 6, "Ra'anana", 10500));

            seniorEmployees.Add(new SeniorEmployee("David", "Huzt", 21, "6741", 3, "BatYam", 8000));
            seniorEmployees.Add(new SeniorEmployee("Dayana", "Prince", 23, "1690", 1, "Petah Tiqwa", 8700));
            seniorEmployees.Add(new SeniorEmployee("Lisa", "Lisa", 32, "118", 0, "TelAviv", 7500));

            clients.Add(new Client("Ayal", "Boged", 42, "4433", 4000));
            clients.Add(new Client("Anakin", "Skywalker", 23, "6666", 16600));
            clients.Add(new Client("Obi-Wan", "Kenobi", 57, "9999", 17000));

            InitializeComponent();
        }

        //private void firstClient()
        //{
        //    Client david = new Client();
        //    Client alex = new Client("alex", "huztishvili", 27, "22134", 2000);
        //    clients.AddFirst(david);
        //    clients.AddLast(alex);

        //    //david.accountMovment.AddLast(david.BankBalance = (-50)); //we dont need to add manualy cuz when we update the bank balance is will add to the account movment and update teh value
        //    //david.accountMovment.AddLast(new AccountMovment(-87, david.BankBalance));

        //    david.BankBalance = -50;

        //    alex.BankBalance = 80;

        //}

        //private void firstRegWorker()
        //{
        //    regularWorkers.AddFirst(new RegularWorker("aviv", "moshe", 25, "2212", 2, "ra'anana", 7000));
        //    regularWorkers.AddLast(new RegularWorker("nativ", "cohen", 30, "5554", 4, "tel-aviv", 8500));
        //}

        //private void firstSenWorker()
        //{
        //    seniorEmployees.AddFirst(new SeniorEmployee("dayana", "prince", 24, "6741", 6, "petach-tikva", 10000));
        //    seniorEmployees.AddLast(new SeniorEmployee("dave", "king", 21, "5614", 7, "bat-yam", 10000));
        //}

        //LinkedList<RegularWorker> regularWorkers = new LinkedList<RegularWorker>();
        //LinkedList<SeniorEmployee> seniorEmployees = new LinkedList<SeniorEmployee>();
        //LinkedList<Client> clients = new LinkedList<Client>();
        //List<Client> clients = new List<Client>();


        //int logInworkFlag = 0;  //need to make a log out button to reset this flag if we want to cunnect woth another client or worker
        //int logINclientFlag = 0;

        Client currClient = new Client();
        //RegularWorker currRegularWorker;
        //SeniorEmployee currSeniorEmployye;

        //Client currclient = new Client(); /*= clients.First;*/
        RegularWorker currRegWorker = new RegularWorker();
        SeniorEmployee currSenEmploye = new SeniorEmployee();

        int currIClient = -1;
        int currIRegWorker = -1;
        int currISenEmployee = -1;

        //-----------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = clients;

            //Table.Columns.Add("")

            //dataGridView1.DataSource = clients;
            //try
            //{
            //    dataGridView1.DataSource = clients[currIClient].accountMovment;

            //}
            ////dataGridView1.DataSource = clients[currIClient].accountMovment;
            //catch { }
            //finally
            //{
            //    //dataGridView1.DataSource = clients[currIClient].accountMovment;
            //}

        }

        
        //--------------------------------------------------------------------------



        private void button1_Click(object sender, EventArgs e) //Log in
        {
            //panel1 PanelProduct.Visible = !PanelProduct.Visible;
            panel1.Visible = !panel1.Visible;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //for the log in, 0 == client, 1 == worker
        {
            //if(comboBox2.SelectedIndex == 0)
            //{
            //    textBox2.Visible = !textBox2.Visible;
            //    label2.Visible = !label2.Visible;
            //}
            //if(comboBox2.SelectedIndex == 1)
            //{
            //    textBox1.Visible = !textBox1.Visible;
            //    label1.Visible = !label1.Visible;
            //}
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox1.Clear();
            //}

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    textBox1.Clear();
            //}

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // 'log in' button
        {
            String currText1 = textBox2.Text;

            int i;
            //int currI = -1;

            //List<Client> temp = clients;

            for(i=0; i<clients.Count;i++)
            {

                if(clients[i].CurrAccountNumberString == currText1)
                {
                    //currClient = temp[i];
                    //break;
                    currIClient = i;
                    i = clients.Count;
                }
            }

            //if(currClient.CurrAccountNumberString == textBox2.Text)
            if(currIClient != -1)
            {
                //panel2.Visible = !panel2.Visible;

                //label11.Text = currClient.FirstName;
                //label12.Text = currClient.LastName;
                //label14.Text = (currClient.BankBalance).ToString();
                //label29.Text = (currClient.AcoountLim).ToString();
                //if (currClient.IsCardActive == true)
                //{
                //    label17.Text = "Active";
                //}
                //else
                //{
                //    label17.Text = "Not Active!";
                //}
                //label19.Text = (currClient.CurrCardNumber).ToString();
                //label25.Text = (currClient.CurrCardCVV).ToString();
                //label23.Text = currClient.CurrAccountNumberString;
                //label20.Text = currClient.FirstName;
                //label21.Text = currClient.LastName;

                panel2.Visible = !panel2.Visible;

                label11.Text = clients[currIClient].FirstName + " " + clients[currIClient].LastName; // + ",    " + clients[currI].Id;
                //label12.Text = clients[currI].Id;   //--------------------maybe not working---------------------//
                label14.Text = clients[currIClient].BankbalanceString;
                label29.Text = clients[currIClient].AccountLimString;
                if (clients[currIClient].IsCardActive == true)
                {
                    label17.Text = "Active";
                }
                else
                {
                    label17.Text = "Not Active!";
                }
                label19.Text = (clients[currIClient].CurrCardNumber).ToString();
                label25.Text = (clients[currIClient].CurrCardCVV).ToString();
                label23.Text = clients[currIClient].CurrAccountNumberString;
                label20.Text = clients[currIClient].FirstName + " " + clients[currIClient].LastName;
                //label21.Text = clients[currI].LastName;

                //currClient = clients[currI];
            }
            else
            {
                MessageBox.Show("the Client coes not exist!!");
                textBox2.Clear();
            }

            //panel2.Visible = !panel2.Visible;

            //label11.Text = currClient.FirstName;
            //label12.Text = currClient.LastName;
            //label14.Text = (currClient.BankBalance).ToString();
            //label29.Text = (currClient.AcoountLim).ToString();
            //if(currClient.IsCardActive == true)
            //{
            //    label17.Text = "Active";
            //}
            //else
            //{
            //    label17.Text = "Not Active!";
            //}
            //label19.Text = (currClient.CurrCardNumber).ToString();
            //label25.Text = (currClient.CurrCardCVV).ToString();
            //label23.Text = currClient.CurrStringAccountNumber;
            //label20.Text = currClient.FirstName;
            //label21.Text = currClient.LastName;
            
            
            //----------------------------------------------------------------------------------------------------//
            
            //It will be better to make a argumant for the ind values in the class, that way we can change them but not effect whao is in the class
            /*/*if(comboBox2.SelectedIndex == 0) // client
            {



                foreach(Client temp in clients)
                {

                    if(temp.CurrStringAccountNumber == textBox2.Text)
                    {
                        currClient = temp;
                        break;
                    }
                    else
                    {
                        currClient = null;
                    }
                }
                if(currClient == null)
                {
                    MessageBox.Show("client does not exist!");
                }

                panel2.Visible = !panel2.Visible;

                label11.Text = currClient.FirstName;
                label12.Text = currClient.LastName;
                label14.Text = currClient.BankBalance.ToString();
                if(currClient.IsCardActive == true)
                {
                    label17.Text = "Avtive";
                }
                else if(currClient.IsCardActive == false)
                {
                    label17.Text = "Not Active";
                }
                label19.Text = currClient.CurrCardNumber.ToString();
                label25.Text = currClient.CurrCardCVV.ToString();
                label23.Text = currClient.CurrAccountNumber.ToString();
                label20.Text = currClient.FirstName + " " + currClient.LastName;
                label29.Text = currClient.AcoountLim.ToString();
                 



                //panel2.Visible = !panel2.Visible;
            }*/

            /*if(comboBox1.SelectedIndex == 1) // worker
            {
                int flag = 0;
                int count = 0;
                RegularWorker reg = regularWorkers.First();
                SeniorEmployee sen = seniorEmployees.First();
                int i;

                //LinkedList<RegularWorker> regularWorkersTemp = regularWorkers;


                //foreach (RegularWorker reg in regularWorkers)
                //{
                //    if(reg.CurrStringWorkNumber == textBox1.Text)
                //    {
                //        currRegWorker = reg;
                //        flag = 1;
                //        break;
                //    }
                //}

                //while (count < regularWorkers.Count)
                //{
                //    if(reg.CurrStringWorkNumber == textBox1.Text)
                //    {
                //        currRegWorker = reg;
                //        flag = 1;
                //        break;
                //    }
                //    count++;
                //    regularWorkersTemp.Find
                //}

                //foreach (RegularWorker reg1 in regularWorkers)
                //{
                //    if (reg.CurrStringWorkNumber == textBox1.Text)
                //    {
                //        currRegWorker = reg;
                //        flag = 1;
                //        break;
                //    }
                //}

                for(i = 0; i<regularWorkers.Count; i++)
                {
                    if(regularWorkers[i].CurrStringWorkNumber == textBox1.Text)
                    {
                        currRegWorker = regularWorkers[i];
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    //foreach(SeniorEmployee sen in seniorEmployees)
                    //{
                    //    if(sen.CurrStringWorkNumber == textBox1.Text)
                    //    {
                    //        currSenEmploye = sen;
                    //        flag = 1;
                    //        break;
                    //    }
                    //}

                    //count = 0;
                    //while (count < seniorEmployees.Count)
                    //{
                    //    if (sen.CurrStringWorkNumber == textBox2.Text)
                    //    {
                    //        currSenEmploye = sen;
                    //        flag = 1;
                    //        break;
                    //    }
                    //    count++;
                    //}

                    for(i=0; i<seniorEmployees.Count; i++)
                    {
                        if(seniorEmployees[i].CurrStringWorkNumber == textBox1.Text)
                        {
                            currSenEmploye = seniorEmployees[i];
                            flag = 1;
                            break;
                        }
                    }

                    //if (flag == 0)
                    //{
                    //    MessageBox.Show("the Worker does not exist!");
                    //    textBox1.Clear();
                    //}
                }

                if (flag == 0)
                {
                    MessageBox.Show("the Worker does not exist!");
                    textBox1.Clear();
                }


                if (flag != 0)
                {
                    int currworkerSalaryint = currRegWorker.Salary;
                    string currworkerSalaryString = currRegWorker.SalaryString;

                    panel4.Visible = !panel4.Visible;

                    label31.Text = currRegWorker.FirstName + " " + currRegWorker.LastName;
                    label33.Text = currRegWorker.CurrStringWorkNumber;
                    label40.Text = currRegWorker.WorkCity;
                    label42.Text = currRegWorker.SalaryString;


                }

                ////int currText = Int32.Parse(textBox1.Text);
                //if (currText >= 1000)
                //{
                //    foreach (RegularWorker reg in regularWorkers)
                //    {
                //        if (reg.CurrWorkNumber == currText)
                //        {
                //            currRegWorker = reg;
                //        }
                //        else
                //        {
                //            currRegWorker = null;
                //        }
                //    }

                //    label31.Text = currRegWorker.FirstName + " " + currRegWorker.LastName;
                //    label33.Text = currRegWorker.CurrWorkNumber.ToString();

                //    if (panel5.Visible == true)
                //    {
                //        clients.AddLast(new Client(textBox10.Text, textBox11.Text, Int32.Parse(textBox12.Text), textBox13.Text, Int32.Parse(textBox14.Text)));

                //    }

                //    panel4.Visible = !panel4.Visible;
                //}
                //else if (currText < 1000 && currText > 0)
                //{
                //    foreach (SeniorEmployee sen in seniorEmployees)
                //    {
                //        if (sen.CurrWorkNumber == currText)
                //        {
                //            currSenEmploye = sen;
                //        }
                //        else
                //        {
                //            currSenEmploye = null;
                //        }
                //    }

                //}
                //else if (currRegWorker == null)
                //{
                //    MessageBox.Show("the worker does not exist");
                //}
                //else if (currSenEmploye == null)
                //{
                //    MessageBox.Show("the worker does not exist");
                //}
            }*/


            ////if (comboBox1.SelectedIndex == 0)
            ////{
            ////}
            ////if (comboBox1.SelectedIndex == 1)
            ////{
            ////}

            //int flag = 0;
            //int worker = -1; //if -1 then not logingg in with worker, if 0 log in with reg worker, if 1 then SeniorEmployee

            ////Client currClient;

            //if (logINclientFlag == 1)
            //{
            //    //clients.Find(currClient.CurrAccountNumber == Int32.Parse(textBox2.Text))
            //    //clients.Find(Client Int32.Parse(textBox2.Text));
            //    //clients.Find
            //    //Client temp = clients.First();
            //    //int clientsSize = 0;
            //    //while(temp != null)
            //    //{
            //    //    clientsSize++;
            //    //    temp=clients.next
            //    //}
            //    //int textAccountNumber = Int32.Parse(textBox2.Text);
            //    //int clientsSize = clients.Count();
            //    //Client temp;
            //    //for(int i= 0; i< clientsSize; i++)
            //    //{
            //    //    //temp = clients[i
            //    //    //if
            //    //}

            //    //panel2.Visible = !panel2.Visible;  the last rhgingto do, first make every thing ready for view


            //    //int currText = 0;
            //    //Int32.TryParse(textBox2.Text, out currText);
            //    //foreach (Client temp in clients)
            //    //{
            //    //    if(temp.CurrAccountNumber==currText)
            //    //    {
            //    //        // open the menu for the client
            //    //        flag = 1;
            //    //        currClient = temp;
            //    //    }
                    
            //    //}


            //    foreach(Client temp in clients)
            //    {
            //        if (temp.CurrAccountNumber.ToString() == textBox2.Text)
            //        {
            //            flag = 1;
            //            currClient = temp;
            //        }

            //    }

            //    if(flag == 1)
            //    {
            //        label11.Text = currClient.FirstName + currClient.LastName;

            //    }

            //    //dataGridView1.Rows.Add(currClient.accountMovment.Last.);
            //    //dataGridView1.DataSource = currClient.accountMovment;


            //    if (flag == 1)
            //    {
            //        dataGridView1.Rows.Add(clients.Last.Value);
            //        panel2.Visible = !panel2.Visible;
            //    }
            //    //dataGridView1.Rows.Add(clients.Last);

            //}

            //if(logInworkFlag != -1)
            //{
            //    if (logInworkFlag == 1)
            //    {
            //        int currText = Int32.Parse(textBox1.Text);

            //        if (currText >= 1000)
            //        {
            //            foreach (RegularWorker reg in regularWorkers)
            //            {
            //                if (reg.CurrWorkNumber == currText)
            //                {
            //                    //open menu of the reg worker
            //                }
            //            }
            //        }
            //        if (currText < 1000)//&& currText > 0)
            //        {
            //            foreach (SeniorEmployee sen in seniorEmployees)
            //            {
            //                if (sen.CurrWorkNumber == currText)
            //                {
            //                    //open menu of reg worker
            //                }
            //            }
            //        }
            //    }
            //    //int currText= Int32.Parse(textBox1.Text);
                
            //    //if(currText>=1000)
            //    //{
            //    //    foreach(RegularWorker reg in regularWorkers)
            //    //    {
            //    //        if (reg.CurrWorkNumber == currText)
            //    //        {
            //    //            //open menu of the reg worker
            //    //        }
            //    //    }
            //    //}
            //    //if(currText<1000 )//&& currText > 0)
            //    //{
            //    //    foreach(SeniorEmployee sen in seniorEmployees)
            //    //    {
            //    //        if(sen.CurrWorkNumber == currText)
            //    //        {
            //    //            //open menu of reg worker
            //    //        }
            //    //    }
            //    //}


            //}*/





        }



        

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void button2_Click_1(object sender, EventArgs e) //'create' button (create worker)
        {
            if (comboBox1.SelectedIndex == 0) //RegularWorker
            {
                RegularWorker temp = new RegularWorker(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text), textBox6.Text, Int32.Parse(textBox7.Text), textBox8.Text, Int32.Parse(textBox9.Text));
                //regularWorkers.AddLast(temp);
                //regularWorkers.AddRange(temp);
                //regularWorkers.Insert(regularWorkers.Count, temp); //we alwase insert to the end but the length of the list does not chanage so we are overriding,
                                                                   //we need to add in the place after the last objecy in the array
                regularWorkers.Add(temp);
                
                MessageBox.Show("added a new Regular Worker\nyour worke numebr is: "+ temp.CurrWorkNumberString);

                //panel3.Visible = !panel3.Visible; //hide the pannle after adding

                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }

            if (comboBox1.SelectedIndex == 1) //SeniorEmployee
            {
                SeniorEmployee temp = new SeniorEmployee(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text), textBox6.Text, Int32.Parse(textBox7.Text), textBox8.Text, Int32.Parse(textBox9.Text));
                //seniorEmplo                regularWorkers.Insert(regularWorkers.Count - 1, yees.AddLast(temp);
                //seniorEmployees.Insert(seniorEmployees.Count, temp);

                seniorEmployees.Add(temp);

                MessageBox.Show("added a new Senior Employee\nyour worke numebr is: " + temp.CurrWorkNumberString);
                //panel3.Visible = !panel3.Visible; //hide the pannle after adding

                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();

            }

            //panel3.Visible = !panel3.Visible; //hide the pannle after adding

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //Client Panle

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            //hello, 
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //name of the client

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) // log out
        {
            panel2.Visible = !panel2.Visible;
            currClient = clients.First();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            //panel7.Visible = !panel7.Visible;

            if (panel7.Visible == true)
            {
                panel7.Visible = false;
            }
            else
            {
                panel7.Visible = true;
            }

            //if(textBox16.Text == currClient.Id)
            //{
            //    if (textBox17.Text == (currClient.CurrCardCVV).ToString())
            //    {
            //        MessageBox.Show((currClient.CurrCardPassword).ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show("Incorrect Values!!");
            //        textBox16.Clear();
            //        textBox17.Clear();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Values!!");
            //    textBox16.Clear();
            //    textBox17.Clear();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel9.Visible == true)
            {
                panel9.Visible = false;
            }
            else
            {
                panel9.Visible = true;
                label49.Text = (currClient.Laon).ToString();
            }
            //panel9.Visible = !panel9.Visible;
            //label49.Text = (currClient.Laon).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int currText = Int32.Parse(textBox18.Text);

            if(currText > clients[currIClient].Laon)
            {
                MessageBox.Show("You cant take this laon!!\nPlease try again:");
                textBox18.Clear();
            }
            else if(currText<= clients[currIClient].Laon)
            {
                clients[currIClient].CurrLaon = currText;

                MessageBox.Show("Your laon was Successful!\nThank you for choosing us");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Laon is: " + (clients[currIClient].CurrLaon).ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int currText = Int32.Parse(textBox19.Text);

            if(currText > clients[currIClient].Mortgage)
            {
                MessageBox.Show("You cant take this Mortgage!!\nPlease try again:");
                textBox19.Clear();
            }
            else if(currText <= clients[currIClient].Mortgage)
            {
                clients[currIClient].CurrMortgage = currText;
                MessageBox.Show("Your Mortgage was Successful!\nThank you for choosing us");

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Mortgage is: " + (clients[currIClient].CurrMortgage).ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(panel6.Visible == true)
            {
                textBox27.Clear();
                panel6.Visible = false;
            }
            else
            {
                panel6.Visible = !panel6.Visible;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //int currText1 = Int32.Parse(textBox27.Text); //Unhandeld Exprion
            //int currTaxt2 = Int32.Parse(textBox26.Text);
            string currText1 = textBox27.Text;
            //string currText2 = textBox26.Text;

            int i;
            //int currI = -1;

            //List<RegularWorker> temp1 = regularWorkers;

            //if(temp1.Contains(CurrWorkNumberString == currText1))

            //for (i = 0; i < (regularWorkers.Count - 1); i++)
            for (i = 0; i < regularWorkers.Count; i++)
            {
                //if (regularWorkers[i].CurrWorkNumberString == currText1)
                //{
                //    currRegWorker = regularWorkers[i];
                //    i = regularWorkers.Count; //to break the loop
                //}
                if(regularWorkers[i].CurrWorkNumberString == currText1)
                {
                    currIRegWorker = i;
                    i = regularWorkers.Count;
                }
            }
            //panel4.Visible = true;
            //panel4.Visible = !panel4.Visible;

            //if (currRegWorker.CurrWorkNumberString == currText1)
            //{
            //    //panel4.Visible = !panel4.Visible;
            //    label31.Text = currRegWorker.FirstName;
            //    label53.Text = currRegWorker.LastName;
            //    label40.Text = currRegWorker.WorkCity;
            //    label42.Text = currRegWorker.SalaryString;
            //    label44.Text = currRegWorker.YearSalaryString;
            //    button9.Visible = !button9.Visible;
            //}
            //--------------------------------------//
            //if(regularWorkers[currI].CurrWorkNumberString == currText1)
            if (currIRegWorker != -1)
            {
                //panel4.Visible = !panel4.Visible;
                panel4.Visible = true;
                label31.Text = regularWorkers[currIRegWorker].FirstName;
                label53.Text = regularWorkers[currIRegWorker].LastName;
                label67.Text = regularWorkers[currIRegWorker].Id;
                label33.Text = regularWorkers[currIRegWorker].CurrWorkNumberString;
                label40.Text = regularWorkers[currIRegWorker].WorkCity;
                label42.Text = regularWorkers[currIRegWorker].SalaryString;
                label44.Text = regularWorkers[currIRegWorker].YearSalaryString;
                //button9.Visible = !button9.Visible;
                button9.Visible = true;

                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;

                currRegWorker = regularWorkers[currIRegWorker];
            }
            else
            {
                MessageBox.Show("The Worker does not exist!");
                textBox27.Clear();
            }


            //if(currText1 != null)
            //{
            //    List<RegularWorker> temp1 = regularWorkers;

            //    //if(temp1.Contains(CurrWorkNumberString == currText1))

            //    for(i = 0; i<(temp1.Count-1); i++)
            //    {
            //        if(temp1[i].CurrWorkNumberString == currText1)
            //        {
            //            currRegWorker = temp1[i];
            //            i = temp1.Count; //to break the loop
            //        }
            //    }
            //    if(currRegWorker.CurrWorkNumberString == currText1)
            //    {
            //        panel4.Visible = !panel4.Visible;
            //        label31.Text = currRegWorker.FirstName;
            //        label53.Text = currRegWorker.LastName;
            //        label40.Text = currRegWorker.WorkCity;
            //        label42.Text = currRegWorker.SalaryString;
            //        label44.Text = currRegWorker.YearSalaryString;
            //        button9.Visible = !button9.Visible;
            //    }
            //    else
            //    {
            //        MessageBox.Show("The Worker does not exist!");
            //        textBox27.Clear();
            //    }

            //    //for(i=0; i<temp1.Count; i++)
            //    //{
            //    //    if(temp1[i].CurrStringWorkNumber == textBox27.Text) //.Equals(currText1)) // == currText1)
            //    //    {
            //    //        currRegWorker = temp1[i];
            //    //        break;
            //    //    }
            //    //}
            //    //if(currRegWorker.CurrStringWorkNumber == currText1)
            //    //{
            //    //    panel4.Visible = !panel4.Visible;
            //    //    label31.Text = currRegWorker.FirstName;
            //    //    label53.Text = currRegWorker.LastName;
            //    //    label40.Text = currRegWorker.WorkCity;
            //    //    label42.Text = currRegWorker.SalaryString;
            //    //    label44.Text = currRegWorker.YearSalaryString;
            //    //    button9.Visible = !button9.Visible;
            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("The Worker does not exist!");
            //    //    textBox27.Clear();
            //    //}


            //}

            //if(currText2 != null)
            //{
            //    List<SeniorEmployee> temp2 = seniorEmployees;

            //    for(i=0; i< (temp2.Count-1); i++)
            //    {
            //        //if(temp2[i].CurrWorkNumberString.Equals(currText2)) // == currText2.)
            //        //{
            //        //    currSenEmploye = temp2[i];
            //        //    break;
            //        //}
            //        if (temp2[i].CurrWorkNumberString == currText2)
            //        {
            //            currSenEmploye = temp2[i];
            //            i = temp2.Count; //break the loop
            //        }
            //    }

            //    if(currSenEmploye.CurrWorkNumberString == currText2)
            //    {
            //        panel4.Visible = !panel4.Visible;

            //        label31.Text = currSenEmploye.FirstName;
            //        label53.Text = currSenEmploye.LastName;
            //        label40.Text = currSenEmploye.WorkCity;
            //        label42.Text = currSenEmploye.SalaryString;
            //        label44.Text = currSenEmploye.YearSalaryString;

            //        button17.Visible = !button17.Visible;
            //        button18.Visible = !button18.Visible;
            //        button19.Visible = !button19.Visible;
            //    }
            //    else
            //    {
            //        MessageBox.Show("The Worker does not exist!");
            //        textBox26.Clear();
            //    }
            //}

        }

        private void button9_Click(object sender, EventArgs e) // add client with worker
        {
            panel5.Visible = !panel5.Visible;
        }

        private void button10_Click(object sender, EventArgs e) // craete a new client
        {
            Client temp = new Client(textBox10.Text, textBox11.Text, Int32.Parse(textBox12.Text), textBox13.Text, Int32.Parse(textBox14.Text));
            //clients.Insert(clients.Count, temp);
            clients.Add(temp);

            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();

            MessageBox.Show("Added a new Client\nNew Client Number:" + temp.CurrAccountNumberString);
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            panel11.Visible = !panel11.Visible;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //int currText1 = Int32.Parse(textBox20.Text);
            String currText1 = textBox20.Text;
            int currText2 = Int32.Parse(textBox21.Text);

            //List<Client> temp = clients;

            int i;
            int currI = -1;

            for(i=0; i<clients.Count; i++)
            {
                if(clients[i].CurrAccountNumberString == currText1)
                {
                    //currClient = temp[i];
                    ////break;
                    //i = temp.Count;

                    currI = i;
                    i = clients.Count;
                }
            }
            //if(currClient.CurrAccountNumberString == currText1)
            //{
            //    currClient.AcoountLim = currText2;
            //    currClient.AccountLimString = textBox21.Text;
            //}
            if(currI != -1)
            {
                clients[currI].AcoountLim = currText2;
                clients[currI].AccountLimString = textBox21.Text;

                MessageBox.Show("The account's " + currText1 + "LIm has been updated!");
                textBox20.Clear();
                textBox21.Clear();
            }
            else
            {
                MessageBox.Show("the Client does not exist!");
                textBox20.Clear();
                textBox21.Clear();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel12.Visible = !panel12.Visible;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string currText1 = textBox22.Text;
            String currText2 = textBox23.Text;

            //List<Client> temp = clients;

            int i;
            int currI = -1;

            for (i = 0; i < clients.Count; i++)
            {
                if (clients[i].CurrAccountNumberString == currText1)
                {
                    //currClient = temp[i];
                    ////break;
                    //i = temp.Count;
                    currI = i;
                    i = clients.Count;
                }

            }
            //if (currClient.CurrAccountNumberString == currText1)
            //{
            //    if(currText2 == "t" || currText2 == "T")
            //    {
            //        currClient.IsCardActive = true;
            //    }
            //    if(currText2 == "f" || currText2 == "F")
            //    {
            //        currClient.IsCardActive = false;
            //    }
            //}
            if(currI != -1)
            {
                if (currText2 == "t" || currText2 == "T" || currText2 == "Active" || currText2 == "active" || currText2 == "true" || currText2 == "True")
                {
                    clients[currI].IsCardActive = true;
                }
                if (currText2 == "f" || currText2 == "F" || currText2 == "false" || currText2 == "False")
                {
                    clients[currI].IsCardActive = false;
                }
                MessageBox.Show("The account's " + currText1 + "Card State has beed changed");
                textBox22.Clear();
                textBox23.Clear();
            }
            else
            {
                MessageBox.Show("the Client does not exist!");
                textBox22.Clear();
                textBox23.Clear();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel13.Visible = !panel13.Visible;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            String currText1 = textBox24.Text;
            int currText2 = Int32.Parse(textBox25.Text);

            //List<Client> temp = clients;

            int i;
            int currI = -1;

            for (i = 0; i < clients.Count; i++)
            {
                if (clients[i].CurrAccountNumberString == currText1)
                {
                    //currClient = temp[i];
                    ////break;
                    //i = temp.Count;
                    currI = i;
                    i = clients.Count;
                }

            }
            //if (currClient.CurrAccountNumberString == currText1)
            //{
            //    currClient.Mortgage = currText2;
            //    currClient.CurrMortgage = currText2;
            //}
            if(currI != -1)
            {
                if(clients[currI].Mortgage < currText2)
                {
                    clients[currI].Mortgage = currText2;
                    clients[currI].CurrMortgage = currText2;
                    clients[currI].CurrMortgageString = textBox25.Text;

                    MessageBox.Show("The account's " + currText1 + "Mortgage has been updated!");
                    textBox24.Clear();
                    textBox25.Clear();
                }
                else if(clients[currI].Mortgage >= currText2)
                {
                    clients[currI].CurrMortgage = currText2;
                    clients[currI].CurrMortgageString = textBox25.Text;
                    MessageBox.Show("The account's " + currText1 + "Mortgage has been Allowd!");
                    textBox24.Clear();
                    textBox25.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("the Client does not exist!");
                textBox24.Clear();
                textBox25.Clear();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (panel14.Visible == true)
            {
                textBox26.Clear();
                panel14.Visible = false;
            }
            else
            {
                panel14.Visible = !panel14.Visible;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String currText1 = textBox26.Text;

            int i;
            //int currI = -1;

            //List<RegularWorker> temp1 = regularWorkers;

            //if(temp1.Contains(CurrWorkNumberString == currText1))

            for (i = 0; i < seniorEmployees.Count; i++)
            {
                if (seniorEmployees[i].CurrWorkNumberString == currText1)
                {
                    //currSenEmploye = seniorEmployees[i];
                    //i = seniorEmployees.Count; //to break the loop
                    currISenEmployee = i;
                    i = seniorEmployees.Count; // to break the loop
                }
            }
            //if (currSenEmploye.CurrWorkNumberString == currText1)
            //{
            //    panel4.Visible = !panel4.Visible;
            //    label31.Text = currSenEmploye.FirstName;
            //    label53.Text = currSenEmploye.LastName;
            //    label40.Text = currSenEmploye.WorkCity;
            //    label42.Text = currSenEmploye.SalaryString;
            //    label44.Text = currSenEmploye.YearSalaryString;

            //    button17.Visible = !button17.Visible;
            //    button18.Visible = !button18.Visible;
            //    button19.Visible = !button19.Visible;

            //}
            if(currISenEmployee != -1)
            {

                panel4.Visible = !panel4.Visible;
                label31.Text = seniorEmployees[currISenEmployee].FirstName;
                label53.Text = seniorEmployees[currISenEmployee].LastName;
                label67.Text = seniorEmployees[currISenEmployee].Id;
                label33.Text = seniorEmployees[currISenEmployee].CurrWorkNumberString;
                label40.Text = seniorEmployees[currISenEmployee].WorkCity;
                label42.Text = seniorEmployees[currISenEmployee].SalaryString;
                label44.Text = seniorEmployees[currISenEmployee].YearSalaryString;

                button17.Visible = !button17.Visible;
                button18.Visible = !button18.Visible;
                button19.Visible = !button19.Visible;
                button9.Visible = false;
                panel5.Visible = false;

                currSenEmploye = seniorEmployees[currISenEmployee];
            }
            else
            {
                MessageBox.Show("The Worker does not exist!");
                textBox26.Clear();
            }


            //List<SeniorEmployee> temp2 = seniorEmployees;

            //    for(i=0; i< (temp2.Count-1); i++)
            //    {
            //        //if(temp2[i].CurrWorkNumberString.Equals(currText2)) // == currText2.)
            //        //{
            //        //    currSenEmploye = temp2[i];
            //        //    break;
            //        //}
            //        if (temp2[i].CurrWorkNumberString == currText2)
            //        {
            //            currSenEmploye = temp2[i];
            //            i = temp2.Count; //break the loop
            //        }
            //    }

            //    if(currSenEmploye.CurrWorkNumberString == currText2)
            //    {
            //        panel4.Visible = !panel4.Visible;

            //        label31.Text = currSenEmploye.FirstName;
            //        label53.Text = currSenEmploye.LastName;
            //        label40.Text = currSenEmploye.WorkCity;
            //        label42.Text = currSenEmploye.SalaryString;
            //        label44.Text = currSenEmploye.YearSalaryString;

            //        button17.Visible = !button17.Visible;
            //        button18.Visible = !button18.Visible;
            //        button19.Visible = !button19.Visible;
            //    }
            //    else
            //    {
            //        MessageBox.Show("The Worker does not exist!");
            //        textBox26.Clear();
            //    }


        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            textBox27.Clear();
            textBox26.Clear();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //if(panel15.Visible == true)
            //{
            //    panel15.Visible = false;
            //}
            //else
            //{
            //    panel15.Visible = true;
            //}
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //String currText1 = textBox1.Text;
            //String currText2 = textBox15.Text;

            //int i;
            //int currI = -1;

            //for(i = 0; i<clients.Count; i++)
            //{
            //    if(clients[i].Id == currText1 && clients[i].LastName == currText2)
            //    {
            //        currI = i;
            //        i = clients.Count;
            //    }
            //}
            //if(currI != -1)
            //{
            //    MessageBox.Show("you'r Accout Number is: " + clients[currI].CurrAccountNumberString);
            //    textBox1.Clear();
            //    textBox15.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("The Account does not exist!");
            //    textBox1.Clear();
            //    textBox15.Clear();
            //}

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (panel16.Visible == true)
            {
                panel16.Visible = false;
            }
            else
            {
                panel16.Visible = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            String currText1 = textBox28.Text;
            String currText2 = textBox29.Text;

            int i;
            //int currI = -1;

            for (i = 0; i < regularWorkers.Count; i++)
            {
                if (regularWorkers[i].Id == currText1 && regularWorkers[i].LastName == currText2)
                {
                    currIRegWorker = i;
                    i = regularWorkers.Count;
                }
            }
            if (currIRegWorker != -1)
            {
                MessageBox.Show("you'r Accout Number is: " + regularWorkers[currIRegWorker].CurrWorkNumberString);
                textBox28.Clear();
                textBox29.Clear();
            }
            else
            {
                MessageBox.Show("The Account does not exist!");
                textBox28.Clear();
                textBox29.Clear();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (panel17.Visible == true)
            {
                panel17.Visible = false;
            }
            else
            {
                panel17.Visible = true;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            String currText1 = textBox30.Text;
            String currText2 = textBox31.Text;

            int i;
            //int currI = -1;

            for (i = 0; i < seniorEmployees.Count; i++)
            {
                if (seniorEmployees[i].Id == currText1 && seniorEmployees[i].LastName == currText2)
                {
                    currISenEmployee = i;
                    i = seniorEmployees.Count;
                }
            }
            if (currISenEmployee != -1)
            {
                MessageBox.Show("you'r Accout Number is: " + seniorEmployees[currISenEmployee].CurrWorkNumberString);
                textBox30.Clear();
                textBox31.Clear();
            }
            else
            {
                MessageBox.Show("The Account does not exist!");
                textBox30.Clear();
                textBox31.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(panel10.Visible == true)
            {
                panel10.Visible = false;
            }
            else
            {
                panel10.Visible = true;
                label52.Text = currClient.MortgageString;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (clients[currIClient].Id == textBox16.Text)
            {
                if ((clients[currIClient].CurrCardCVV).ToString() == textBox17.Text)
                {
                    MessageBox.Show((clients[currIClient].CurrCardPassword).ToString());
                    textBox16.Clear();
                    textBox17.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect Values!!");
                    textBox16.Clear();
                    textBox17.Clear();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Values!!");
                textBox16.Clear();
                textBox17.Clear();
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }


        private void button20_Click(object sender, EventArgs e) //for save
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    //formatter.Serialize(stream, clients);
                    //formatter.Serialize(stream, regularWorkers);
                    //formatter.Serialize(stream, seniorEmployees);
                    try
                    {
                        formatter.Serialize(stream, clients);
                        formatter.Serialize(stream, regularWorkers);
                        formatter.Serialize(stream, seniorEmployees);
                    }
                    catch { }
                    finally
                    {
                        //formatter.Serialize(stream, clients);
                        //formatter.Serialize(stream, regularWorkers);
                        //formatter.Serialize(stream, seniorEmployees);
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e) // for load
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                //pts = (FigureList)binaryFormatter.Deserialize(stream);
                //pictureBox1.Invalidate();

                //List<RegularWorker> regularWorkers = new List<RegularWorker>();
                //List<SeniorEmployee> seniorEmployees = new List<SeniorEmployee>();
                //List<Client> clients = new List<Client>();


                //clients = (List<Client>)binaryFormatter.Deserialize(stream);
                //regularWorkers = (List<RegularWorker>)binaryFormatter.Deserialize(stream);
                //seniorEmployees = (List<SeniorEmployee>)binaryFormatter.Deserialize(stream);
                try
                {
                    clients = (List<Client>)binaryFormatter.Deserialize(stream);
                    regularWorkers = (List<RegularWorker>)binaryFormatter.Deserialize(stream);
                    seniorEmployees = (List<SeniorEmployee>)binaryFormatter.Deserialize(stream);
                }
                catch { }
                finally
                {
                    //clients = (List<Client>)binaryFormatter.Deserialize(stream);
                    //regularWorkers = (List<RegularWorker>)binaryFormatter.Deserialize(stream);
                    //seniorEmployees = (List<SeniorEmployee>)binaryFormatter.Deserialize(stream);
                }

                //pictureBox1.Invalidate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            if (panel15.Visible == true)
            {
                panel15.Visible = false;
            }
            else
            {
                panel15.Visible = true;
            }
            //panel15.Visible = true;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {

            String currText1 = textBox1.Text; // id
            String currText2 = textBox15.Text;//last name

            int i;
            //int currI = -1;

            for (i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id == currText1 && clients[i].LastName == currText2)
                {
                    currIClient = i;
                    i = regularWorkers.Count;
                }
            }
            if (currIClient != -1)
            {
                MessageBox.Show("you'r Accout Number is: " + clients[currIClient].CurrAccountNumberString);
                textBox1.Clear();
                textBox15.Clear();
            }
            else
            {
                MessageBox.Show("The Account does not exist!");
                textBox1.Clear();
                textBox15.Clear();
            }


        }
    }
}
