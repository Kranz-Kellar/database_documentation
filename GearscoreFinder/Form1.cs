using CharacterManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearscoreFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                var gearScore = GearScoreParser.GetGearScoreOfPlayer(nicknameOfPlayerToFind.Text, serverOfPlayerToFind.Text);
                playerList.Items.Add($"{nicknameOfPlayerToFind.Text} - {gearScore}");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Персонаж не был найден");
                Logger.Log(LogStatus.ERROR, $"{DateTime.Now} : {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLastSession();
                ViewAvailableServers();
                TransliterationHandler.Init();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка. Подробности в логе");
                Logger.Log(LogStatus.ERROR, $"{DateTime.Now} : {ex.Message}");
            }
        }

        private void ViewAvailableServers()
        {
            var serverList = GearScoreParser.GetAvailableServers();
            foreach(var server in serverList)
            {
                serverOfPlayerToFind.Items.Add(server);
            }
            serverOfPlayerToFind.SelectedIndex = 0;
        }

        private void ClearPlayerList_Click(object sender, EventArgs e)
        {
            playerList.Items.Clear();
        }

        private void LoadLastSession()
        {
            var playersData = SessionHandler.LoadLastSession();
            foreach(var data in playersData)
            {
                playerList.Items.Add(data);
            }
        }

        private void SaveLastSession()
        {
            var playersData = new List<string>();
            for(int i = 0; i < playerList.Items.Count; i++)
            {
                playersData.Add(playerList.Items[i].ToString());
            }
            SessionHandler.SaveLastSession(playersData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLastSession();
        }
    }
}
