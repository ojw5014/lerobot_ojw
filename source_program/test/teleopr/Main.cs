using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenJigWare;

namespace teleopr
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true; // 폼이 키 이벤트를 먼저 받도록 설정
        }
        private Ojw.CProtocol2 m_CMot = new Ojw.CProtocol2();
        private Ojw.CCamera m_CCam = new Ojw.CCamera();
        private Ojw.CParam m_CParam;
        private void frmMain_Load(object sender, EventArgs e)
        {

            m_CParam = new Ojw.CParam(
                txtComport,
                txtBaud,
                txtSpeed_Wait,
                txtSpeed_Move,
                txtCameraIndex,
                chkLeftHanded);
            Ojw.printf_Init(txtPrint);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (m_CMot.IsOpen() == true)
            {
                tmrRead.Enabled = false;
                m_CMot.Close();
                btnConnect.Text = "Connect";
            }
            else
            {
                int nPort = Ojw.CConvert.StrToInt(txtComport.Text);
                int nBaud = Ojw.CConvert.StrToInt(txtBaud.Text);
                m_CMot.Open(nPort, nBaud);

                if (m_CMot.IsOpen() == true)
                {
                    //m_CMot.SyncRendering(m_C3d);
                    btnConnect.Text = "Disconnect";

                    if (chkLeftHanded.Checked == false)
                    {
                        m_CMot.SetParam_Dir(4, true);
                    }
                    m_CMot.SetParam_Dir(6, true);

                    // delay time 을 50 -> 100 으로 변경
                    //m_CMot.Set_WaitTime(100);

                    //m_CMot.SetTorq(false);
                    m_CMot.SetTorq(
                        1, 1, 
                        2, 1,
                        3, 1,
                        4, 1,
                        5, 1,
                        6, 1,
                        11, 0,
                        12, 0,
                        13, 0,
                        14, 0,
                        15, 0,
                        16, 0);
                    m_CMot.SyncRead(1, 2, 3, 4, 5, 6);

                    tmrRead.Enabled = true;
                }

                //m_CMot.SyncRead(m_C3d.m_CHeader.anMotorIDs);

                
                //m_CCom.Open_Socket(5000, "127.0.0.1", false);
            }
        }

        private bool m_bTorq = false;
        private bool m_bTmrRead = false;
        private void tmrRead_Tick(object sender, EventArgs e)
        {
            if (m_bTmrRead) return;
            m_bTmrRead = true;

            if (m_bCmd_Torq)
            {
                m_bCmd_Torq = false;
                if (m_bTorq == true)
                {
                    m_CMot.SetTorq(
                           11, 1,
                           12, 1,
                           13, 1,
                           14, 1,
                           15, 1,
                           16, 1);
                }
                else
                {
                    m_CMot.SetTorq(
                            11, 0,
                            12, 0,
                            13, 0,
                            14, 0,
                            15, 0,
                            16, 0);
                }
            }

            List<float> afVal = new List<float>();
            int nCnt = 0;
#if false
            
            int i;
            m_CMot.SyncRead_NoWait(11, 12, 13, 14, 15, 16);
            float fAngle;
            afVal.Add(200); // Time
            afVal.Add(0); // Delay
            for (i = 11; i <= 16; i++)
            {
                if (m_CMot.IsReceived_Angle(i))
                {
                    fAngle = m_CMot.GetAngle(i);
                    afVal.Add(i - 10);
                    afVal.Add(fAngle);
                    //m_CMot.Set(i - 10, fAngle);
                    nCnt++;
                    //Ojw.printf("{0}, ", fAngle);
                }
            }
            if (nCnt > 0)
                m_CMot.Move(afVal.ToArray());
#else

            //List<float> afVal = new List<float>();
            //m_CMot.SyncRead(11, 12, 13, 14, 15, 16);
            if (m_CMot.SyncRead(11, 12, 13, 14, 15, 16))
            {
                int i;
                float fAngle;
                afVal.Add(m_nTime); // Time
                afVal.Add(0); // Delay
                for (i = 11; i <= 16; i++)
                {
                    if (m_CMot.IsReceived_Angle(i))
                    {
                        fAngle = m_CMot.GetAngle(i);
                        afVal.Add(i - 10);
                        afVal.Add(fAngle);
                        nCnt++;
                        //m_CMot.Set(i - 10, fAngle);
                        //Ojw.printf("{0}, ", fAngle);
                    }
                }
                //i = 17;
                //fAngle = m_CMot.GetAngle(i);
                //afVal.Add(i-10);
                //afVal.Add(fAngle);
                //m_CMot.Set(i - 10, fAngle);
                //Ojw.printf("{0}", m_CMot.GetAngle(i)); Ojw.newline();
                if (nCnt > 0) m_CMot.Move(afVal.ToArray());
            }
#endif
#if false
            if (m_CMot.SyncRead(1, 2, 3, 4, 5, 6))
            {
                int i;
                int nMax = 6;
                float fAngle;
                nCnt = 0;
                string strTmp = "";
                for (i = 1; i <= nMax; i++)
                {
                    if (m_CMot.IsReceived_Angle(i))
                    {
                        fAngle = m_CMot.GetAngle(i);
                        strTmp += String.Format("[{0}],[{1}], ", i, fAngle);
                        nCnt++;
                        //m_CMot.Set(i - 10, fAngle);
                        //Ojw.printf("{0}, ", fAngle);
                    }
                }
                if (nCnt == nMax)
                {
                    Ojw.printf("{0}\r\n", strTmp);
                }
                else
                {
                    Ojw.printf("Error==========!!!!!!!!!!!{0}\r\n", strTmp);
                }
            }

            //m_CMot.SyncRead_With_Address(126, 2, 11, 12, 13, 14, 15, 16);
            
            //if (Math.Abs(m_CMot.m_anMap[12]) > 5)
            //{
            //    Ojw.printf("Vel={0}\r\n", m_CMot.m_anMap[12]);
            //}
                
#endif


            m_bTmrRead = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_CCam.Stop();
            m_CMot.Close();
            m_CParam.Param_Save();
        }

        private bool m_bCam = false;
        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (m_bCam)
            {
                m_bCam = false;
                m_CCam.Stop();
            }
            else
            {
                int nIndex = Ojw.CConvert.StrToInt(txtCameraIndex.Text);

                m_CCam.Init(pnCam, nIndex);
                m_CCam.Start();
                m_bCam = true;
            }
        }
        int m_nTime = 200;
        private void Setup()
        {
            m_CMot.Set_WaitTime(Ojw.CConvert.StrToInt(txtSpeed_Wait.Text));
            m_nTime = Ojw.CConvert.StrToInt(txtSpeed_Move.Text);
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            Setup();
        }

        bool m_bCmd_Torq = false;
        private void btnTorqOn_Click(object sender, EventArgs e)
        {
            if (m_CMot.IsOpen())
            {
                m_bCmd_Torq = true;
                m_bTorq = true;

                //m_CMot.SetTorq(true);
                //m_CMot.SetTorq(
                //        11, 1,
                //        12, 1,
                //        13, 1,
                //        14, 1,
                //        15, 1,
                //        16, 1);
            }
        }

        private void btnTorqOff_Click(object sender, EventArgs e)
        {
            if (m_CMot.IsOpen())
            {
                m_bCmd_Torq = true;
                m_bTorq = false;
                //m_CMot.SetTorq(false);
                //m_CMot.SetTorq(
                //        11, 0,
                //        12, 0,
                //        13, 0,
                //        14, 0,
                //        15, 0,
                //        16, 0);
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                if (m_CMot.IsOpen())
                {
                    m_bCmd_Torq = true;
                    m_bTorq = true;
                }
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                if (m_CMot.IsOpen())
                {
                    m_bCmd_Torq = true;
                    m_bTorq = false;
                }
            }
        }

        private void chkLeftHanded_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeftHanded.Checked == false)
            {
                m_CMot.SetParam_Dir(4, true);
            }
            else
            {
                m_CMot.SetParam_Dir(4, false);
            }
        }

    }
}
