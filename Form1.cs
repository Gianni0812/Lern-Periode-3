using Microsoft.Win32.SafeHandles;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private int Minuspoints = 7;
        private Random random = new Random();
        private int aktuelleFrageIndex = 0;
        private System.Windows.Forms.Timer timer;
        private int time = 15;
        private Color originalcolor = Color.LightBlue;
        
        
        public Form1()
        {
            InitializeComponent();
            FrageAnzeigen();
            label2.Text = $"Points:{Minuspoints}";
            button1.BackColor = originalcolor;
            button2.BackColor = originalcolor;
            button3.BackColor = originalcolor;
            button4.BackColor = originalcolor;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            StartTimer();
        }



        private void FrageAnzeigen()
        {

            var frage = fragen[aktuelleFrageIndex];


            var gemischteAntworten = frage.Antworten.Select((antwort, index) => new { Antwort = antwort, Index = index })
                                                     .OrderBy(x => random.Next())
                                                     .ToList();


            button1.Text = gemischteAntworten[0].Antwort;
            button1.Tag = gemischteAntworten[0].Index;

            button2.Text = gemischteAntworten[1].Antwort;
            button2.Tag = gemischteAntworten[1].Index;

            button3.Text = gemischteAntworten[2].Antwort;
            button3.Tag = gemischteAntworten[2].Index;

            button4.Text = gemischteAntworten[3].Antwort;
            button4.Tag = gemischteAntworten[3].Index;

            label1.Text = frage.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AntwortPrüfen((int)button1.Tag);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            AntwortPrüfen((int)button2.Tag);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            AntwortPrüfen((int)button3.Tag);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            AntwortPrüfen((int)button4.Tag);
        }


        public class Frage
        {
            public string Text { get; set; }
            public string[] Antworten { get; set; }
            public int RichtigeAntwortIndex { get; set; }
        }
        private void AntwortPrüfen(int gewählterIndex)
        {
            var frage = fragen[aktuelleFrageIndex];
            if (Minuspoints != 1 && time != 0)
            {
                if (gewählterIndex == frage.RichtigeAntwortIndex)
                {

                    aktuelleFrageIndex++;
                    if (aktuelleFrageIndex < fragen.Count)
                    {
                        FrageAnzeigen();
                        StartTimer();
                    }
                    else
                    {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        timer.Stop();
                        label1.Text = "Ende des Quiz";
                    }
                }
                else
                {
                    Minuspoints = Minuspoints - 1;
                    label2.Text = $"Points:{Minuspoints}";
                }
            }
            else
            {
                Stopprogramm();
            }

        }
        private void StartTimer()
        {
            time = 15;
            label3.Text = $"Zeit: {time}s";
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = $"Zeit: {time}s";


            if (time <= 0)
            {
                timer.Stop();
                label3.Text = "Zeit abgelaufen!";
                Stopprogramm();

            }
        }
        private void Stopprogramm()
        {
            timer.Stop();
            Minuspoints = 0;
            label2.Text = $"Points:{Minuspoints}";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            if (time == 0)
            {
                label1.Text = "Sie waren zu Langsam!\nSie haben leider nicht so ein gutes Allgemeinwissen.\nEnde des Quiz";

            }
            else
            {

                label1.Text = "Sie haben keine Punkte mehr!\nSie haben leider nicht so ein gutes Allgemeinwissen.\nEnde des Quiz";

            }
        }
        List<Frage> fragen = new List<Frage>
        {
            new Frage
            {
                Text = "Welches Element hat das chemische Symbol 'O'?",
                Antworten = new[] { "Gold", "Sauerstoff", "Silber", "Stickstoff" },
                RichtigeAntwortIndex = 1
            },
            new Frage
            {
                Text = "Was ist die Hauptstadt von Deutschland?",
                Antworten = new[] { "Berlin", "München", "Hamburg", "Köln" },
                RichtigeAntwortIndex = 0
            },
            new Frage
            {
                Text = "Wie viele Kontinente gibt es auf der Erde?",
                Antworten = new[] {"fünf","Sieben","Acht", "Sechs"},
                RichtigeAntwortIndex = 1
            },
            new Frage
            {
                Text = "Was ist die Hauptstadt von Frankreich?",
                Antworten = new[] {"Nizza","Lyon","Paris","Marsaille"},
                RichtigeAntwortIndex = 2
            },
            new Frage
            {
                Text = "Welches ist der längste Fluss der Welt?",
                Antworten = new[] {"Nil","Mississippi","Yangtse","Amazonas"},
                RichtigeAntwortIndex = 0
            },
            new Frage
            {
                Text = "Welcher Planet ist der Sonne am nächsten?",
                Antworten = new[] {"Merkur","Venus","Mars","Jupiter"},
                RichtigeAntwortIndex = 0
            },
            new Frage
            {
                Text = "Wie viele Planeten hat unser Sonnensystem?",
                Antworten = new[] {"Acht", "Neun", "Zehn", "Sieben" },
                RichtigeAntwortIndex = 0
            },
            new Frage
            {
                Text = "Welcher Planet in unserem Sonnensystem hat den grössent Mond?",
                Antworten = new[] {"Jupiter","Saturn","Venus","Neptun"},
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "Welche Tierart kann bis zu 9m hoch springen?",
                Antworten = new[] {"Puma","Antilope","Kenguru","Gepard"},
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "In welchem Jahr wurde der Bundesstaat Schweiz gegründet?",
                Antworten = new[] {"1848","1291","1815","1840"},
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "Welcher See ist der größte vollständig in der Schweiz gelegene See?",
                Antworten = new[] {"Neuenburgersee","Genfersee","Bodensee","Vierwaldstättersee"},
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "Wie schwer war der erste Computer, der 1946 in betrieb genommen wurde?",
                Antworten = new[] {"27 Tonnen","50 Tonnen","2 Tonnen","10 Tonnen"},
                RichtigeAntwortIndex=0  
            },
            new Frage
            {
                Text = "Wie viele Liter Blut pumpt ein menschliches Herz pro Tag?",
                Antworten = new[] {"7.000 Liter", "1.000 Liter","5.000 Liter","10.000 Liter" },
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "Welches ist das kleinste Land der Welt?",
                Antworten = new[] {"Vatikanstadt","Monaco","San Marino","Liechtenstein"},
                RichtigeAntwortIndex=0
            },
            new Frage
            {
                Text = "Welcher Fluss fliesst durch die meisten Länder?",
                Antworten = new[] {"Donau", "Rhein", "Amazonas", "Nil"},
                RichtigeAntwortIndex=0
            }


        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
