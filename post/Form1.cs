using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.IO;
using Microsoft.Win32;
using System.Net;
using OpenQA.Selenium.Interactions;
using post.Properties;

namespace post
{//baris1337
    public partial class Form1 : MaterialForm
    {
        IWebDriver driver = new ChromeDriver();
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        int sa = -1;
        private int index;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            string getFiles = "users.txt";

            List<string> textlines = File.ReadAllLines(getFiles).ToList();

            foreach (var line in textlines)
            {
                listBox1.Items.Add(line);
            }

            materialMultiLineTextBox1.AppendText("[HTTP] Chromedriver.exe Found.");
            materialMultiLineTextBox1.Text += Environment.NewLine;

            materialMultiLineTextBox2.AppendText("[HTTP] Chromedriver.exe Found.");
            materialMultiLineTextBox2.Text += Environment.NewLine;
        }


        private void materialButton3_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://m.facebook.com/");
            try
            {
                IWebElement gmail = driver.FindElement(By.Name("email"));
                gmail.SendKeys(gmailtext.Text);
                IWebElement pass = driver.FindElement(By.Name("pass"));
                pass.SendKeys(passtext.Text);
                IWebElement login = driver.FindElement(By.Name("login"));
                login.Click();

                materialMultiLineTextBox1.AppendText("[SELENIUM] User Authenticate Success.");
                materialMultiLineTextBox1.Text += Environment.NewLine;

            }
            catch (Exception ex)
            {
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }
        private void stoppost_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker2.CancelAsync();

            }

            catch (Exception ex) { }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count > 0)

                using (TextWriter TW = new StreamWriter("users.txt"))
                {

                    foreach (string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);

                    }
                }
                    driver.Quit();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "chromedriver")
                    p.Kill();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "Google Crash Handler")
                    p.Kill();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "post")
                    p.Kill();
        }
        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            if (entername.Text == "")
            {
                ;
            }               
            else
            {
                listBox1.Items.Add(entername.Text);
                entername.Text = "";
            }
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    index = listBox1.IndexFromPoint(e.Location);
                    {
                        if (index == listBox1.SelectedIndex)
                        {
                            contextMenuStrip1.Show();
                        }
                    }
                }
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker1.CancelAsync();
            }

            catch(Exception ex) { }
          
        }
        private void materialButton7_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://facebook.com/messages/");
            try
            {
                IWebElement gmail = driver.FindElement(By.Name("email"));
                gmail.SendKeys(gmailtext.Text);
                IWebElement pass = driver.FindElement(By.Name("pass"));
                pass.SendKeys(passtext.Text);
                pass.SendKeys(OpenQA.Selenium.Keys.Enter);
                materialMultiLineTextBox2.AppendText("[SELENIUM] User Authenticate Success.");
                materialMultiLineTextBox2.Text += Environment.NewLine;
            }
           catch (Exception ex)
            {
            }
    }

        private void materialButton6_Click_1(object sender, EventArgs e)
        {
            int me = 0;
            driver.Navigate().GoToUrl("https://www.facebook.com/friends/list");
            IWebElement find = driver.FindElement(By.XPath("  (//div[contains(@tabindex,'0')])[7]"));
            find.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                IWebElement remove = driver.FindElement(By.XPath("(//span[contains(@dir,'auto')])[88]"));

                remove.Click();
            }
            catch (Exception ex)

            {            
                find.Click();
                IWebElement remove = driver.FindElement(By.XPath("(//span[contains(@dir,'auto')])[89]"));
                remove.Click();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                entername.Text = listBox1.SelectedItem.ToString();
                update.Show();
               materialButton1.Hide();
            }

            catch (Exception ex)
            {
            }
        }
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(index);
            }
            catch (Exception ex)
            {
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, entername.Text);
            update.Hide();
            materialButton1.Show();
            entername.Text = "";
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] getFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            List<string> textlines = File.ReadAllLines(getFiles[0]).ToList();

            foreach (var line in textlines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                sa++;
            try
            {
                listBox1.SelectedIndex = sa;
            }
            catch (Exception ex)

            {
                //  MessageBox.Show("The message has been sent to all users.");
                //materialButton5.PerformClick();

                if ( listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {
                //    MessageBox.Show("The message has been sent to all users.");
                }               
                else
                {
                    sa++;
                }
            }
            if (sa == -1)
            {
                //
            }
            else
            {
                try
                {
                    IWebElement findtarget = driver.FindElement(By.XPath("(//span[contains(.,'" + (listBox1.SelectedItem) + "')])[4]"));
                    Actions actions = new Actions(driver);
                    actions.MoveToElement(findtarget);
                    actions.Perform();
                    findtarget.Click();
                    Thread.Sleep(1000);
                    IWebElement textsend = driver.FindElement(By.XPath("//div[contains(@class,'1mj')]"));
                    textsend.SendKeys(yolla.Text);
                    textsend.SendKeys(OpenQA.Selenium.Keys.Enter);
                    materialMultiLineTextBox2.AppendText("[LOG] Message Sent to [" + listBox1.SelectedItem + "]");
                    materialMultiLineTextBox2.Text += Environment.NewLine;
                    //z
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                sa = -1;
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            double sa = Convert.ToDouble(startnumbertext.Text);
            double ass = Convert.ToDouble(stopnumbertext.Text);
            checkBox1.Checked = false;
            try
            {
                IWebElement postclick = driver.FindElement(By.XPath("(//div[@class='_5xu4'])[2]"));
                postclick.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //5
                IWebElement textarea = driver.FindElement(By.XPath("//textarea[contains(@id,'uniqid_1')]"));
                textarea.SendKeys("#" + teamnametext.Text);
                textarea.SendKeys(OpenQA.Selenium.Keys.Enter);
                textarea.SendKeys(linktext.Text);
                textarea.SendKeys(OpenQA.Selenium.Keys.Enter);
                textarea.SendKeys("#" + sa++.ToString());
                startnumbertext.Text = sa.ToString();
                IWebElement sharebutton = driver.FindElement(By.XPath("(//button[contains(@data-sigil,'composer')])[5]"));
                sharebutton.Click();
                materialMultiLineTextBox1.AppendText("[LOG] Sent post [" + sa + "]");
                materialMultiLineTextBox1.Text += Environment.NewLine;
                startnumbertext.Text = sa++.ToString();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {

            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  double sa = Convert.ToDouble(startnumbertext.Text);
            //  double ass = Convert.ToDouble(stopnumbertext.Text);

            if (startnumbertext.Text == stopnumbertext.Text)
            {
                try
                {
                    backgroundWorker2.CancelAsync();
                }
                catch (Exception ex) { }
               
            }
            else
            {              
                    backgroundWorker2.RunWorkerAsync();
                }

            }
    }
    }

