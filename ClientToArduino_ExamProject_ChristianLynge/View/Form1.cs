using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ClientToArduino_ExamProject_ChristianLynge.Model;

namespace ClientToArduino_ExamProject_ChristianLynge
{
    public partial class Form1 : Form
    {
        Serialport sp = new Serialport();
        ArduinoProtocol protocol = new ArduinoProtocol();
        Train train1 = new Train();
        Train train2 = new Train();
        Accessory acc1 = new Accessory();
        Accessory acc2 = new Accessory();

        public Form1()
        {
            InitializeComponent();
            train1.setAddress(txtTrainAddress1.Text);
            train2.setAddress(txtTrainAddress2.Text);
            acc1.setAddress(txtAcc1.Text);
            acc2.setAddress(txtAcc2.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }
        private string getPort()
        {
            return comboBox1.SelectedItem.ToString();
        }

        private void textboxInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string msg = textboxInput.Text;
            sp.sendMessage(protocol.customMsg(msg), getPort());
        }   

        #region Train1
        private void txtTrainAddress1_TextChanged(object sender, EventArgs e)
        {
            train1.setAddress(txtTrainAddress1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDirection1_Click(object sender, EventArgs e)
        {
            btnDirection1.Text = train1.toggleDir();
            string msg = train1.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnSlower1_Click(object sender, EventArgs e)
        {
            lblSpeed1.Text = train1.decreaseSpeed();
            string msg = train1.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnFaster1_Click(object sender, EventArgs e)
        {
            lblSpeed1.Text = train1.increaseSpeed();
            string msg = train1.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnLights1_Click(object sender, EventArgs e)
        {
            btnLights1.Text = train1.toggleLights();
            string msg = train1.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btnEStop1_Click(object sender, EventArgs e)
        {
            btnEStop1.Text = train1.toggleEStop();
            string msg = train1.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnSound1_Click(object sender, EventArgs e)
        {
            btnSound1.Text = train1.toggleSound();
            string msg = train1.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btnBell1_Click(object sender, EventArgs e)
        {
            btnBell1.Text = train1.toggleBell();
            string msg = train1.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btn1stHorn1_Click(object sender, EventArgs e)
        {
            btn1stHorn1.Text = train1.toggleHorn1();
            string msg = train1.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btn2ndHorn1_Click(object sender, EventArgs e)
        {
            btn2ndHorn1.Text = train1.toggleHorn2();
            string msg = train1.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }
        #endregion

        #region Train2
        private void txtTrainAddress2_TextChanged(object sender, EventArgs e)
        {
            train2.setAddress(txtTrainAddress2.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDirection2_Click(object sender, EventArgs e)
        {
            btnDirection2.Text = train2.toggleDir();
            string msg = train2.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnSlower2_Click(object sender, EventArgs e)
        {
            lblSpeed2.Text = train2.decreaseSpeed();
            string msg = train2.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnFaster2_Click(object sender, EventArgs e)
        {
            lblSpeed2.Text = train2.increaseSpeed();
            string msg = train2.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnLights2_Click(object sender, EventArgs e)
        {
            btnLights2.Text = train2.toggleLights();
            string msg = train2.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btnEStop2_Click(object sender, EventArgs e)
        {
            btnEStop2.Text = train2.toggleEStop();
            string msg = train2.assembleSetSpeed();
            sp.sendMessage(msg, getPort());
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnSound2.Text = train2.toggleSound();
            string msg = train2.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btnBell2_Click(object sender, EventArgs e)
        {
            btnBell2.Text = train2.toggleBell();
            string msg = train2.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btn1stHorn2_Click(object sender, EventArgs e)
        {
            btn1stHorn2.Text = train2.toggleHorn2();
            string msg = train2.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }

        private void btn2ndHorn2_Click(object sender, EventArgs e)
        {
            btn2ndHorn2.Text = train2.toggleHorn2();
            string msg = train2.assembleSetEffect();
            sp.sendMessage(msg, getPort());
        }
        #endregion

        #region Acc1
        private void txtAcc1_TextChanged(object sender, EventArgs e)
        {
            acc1.setAddress(txtAcc1.Text);
        }

        private void btnSwitchAcc1_Click(object sender, EventArgs e)
        {
            acc1.switchState();
            string msg = acc1.assembleAccMsg();
            sp.sendMessage(msg, getPort());
        }
        #endregion

        #region Acc2
        private void txtAcc2_TextChanged(object sender, EventArgs e)
        {
            acc2.setAddress(txtAcc2.Text);
        }

        private void btnSwitchAcc2_Click(object sender, EventArgs e)
        {
            acc2.switchState();
            string msg = acc2.assembleAccMsg();
            sp.sendMessage(msg, getPort());
        }
        #endregion
    }
}
