using Exercice1_JasonGrondin.Model;

namespace Exercice1_JasonGrondin
{
    enum TypeDe
    {
        Normal,
        Pip�,
        PasEncoreBrasser,
    }
    public partial class Form1 : Form
    {
        public De de;

        private TypeDe type = TypeDe.PasEncoreBrasser;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            try
            {
                //Il y a une chance sur trois que le d� soit un d� pip�
                Random rnd = new Random();
                int DecisionTypeDe = rnd.Next(1, 4);

                if (DecisionTypeDe < 3)
                {                    
                    txtTypeDe.Text = "Normal";
                    type = TypeDe.Normal;
                    txtResultatDe.Text = GenererDeRandom().ToString();
                }
                else
                {
                    txtTypeDe.Text = "Pip�";
                    type = TypeDe.Pip�;
                    txtResultatDe.Text = GenererDeRandom().ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private int GenererDeRandom()
        {
            switch (type)
            {
                case TypeDe.Normal:
                    de = new DeNormal();
                    int resultatDeBrasser = de.Brasser();
                    return resultatDeBrasser;

                case TypeDe.Pip�:
                    de = new DePipe();
                    int resultatDePipe = de.Brasser();
                    return resultatDePipe;
   
                default:
                    return 0;
            }
        }
    }
}