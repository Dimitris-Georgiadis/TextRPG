using engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class TestRPG : Form
    {
        private Player _player;

        public TestRPG()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house");

            _player = new Player(10, 10, 20, 0, 1);

            lbHitPoints.Text = _player.CurrentHitPoints.ToString();
            lbGold.Text = _player.Gold.ToString();
            lbExperience.Text = _player.ExperiencePoints.ToString();
            lbLevel.Text = _player.Level.ToString();
        }

        private void TestRPG_Load(object sender, EventArgs e)
        {

        }
    }
}
