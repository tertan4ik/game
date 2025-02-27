using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentroll = 1;
        int playerposblue = 0;
        int playerposyellow=0;
        int playerpospurple=0;
        int playerposbrown=0;
        public MainWindow()
        {
            
            InitializeComponent();
            List<string> coords= new List<string>();
            coords.Add("119,195");
            coords.Add("105,219");
            coords.Add("105,255");
            coords.Add("109,285");
            coords.Add("123,313");
            coords.Add("151,317,red");
            coords.Add("178,312");
            coords.Add("201,326");
            coords.Add("176,351");
            coords.Add("143,365");
            coords.Add("112,372");
            coords.Add("79,379");
            coords.Add("82,411");
            coords.Add("101,439,green");
            coords.Add("137,439");
            coords.Add("167,435");
            coords.Add("194,425");
            coords.Add("223,411,red");
            coords.Add("243,433");
            coords.Add("264,458");
            coords.Add("269,487");
            coords.Add("268,514,green");
            coords.Add("276,541");
            coords.Add("303,547,");
            coords.Add("332,548");
            coords.Add("361,544");
            coords.Add("387,523,red");
            coords.Add("403,501");
            coords.Add("412,476");
            coords.Add("423,450");
            coords.Add("428,422");
            coords.Add("428,396");
            coords.Add("430,370,green");
            coords.Add("434,346");
            coords.Add("439,316");
            coords.Add("464,308");
            coords.Add("481,337");
            coords.Add("483,375");
            coords.Add("479,407");
            coords.Add("476,442");
            coords.Add("470,475,red");
            coords.Add("468,508");
            coords.Add("458,540");
            coords.Add("483,538");
            coords.Add("509,518,green");
            coords.Add("514,490");
            coords.Add("524,461");
            coords.Add("529,436,red");
            coords.Add("535,400");
            coords.Add("535,372");
            coords.Add("532,336,red");
            coords.Add("532,305");
            coords.Add("532,278");
            coords.Add("514,255,green");
            coords.Add("493,240");
            coords.Add("463,227");
            coords.Add("429,229");
            coords.Add("406,256");
            coords.Add("399,291");
            coords.Add("374,317,green");
            coords.Add("349,332");
            coords.Add("346,366");
            coords.Add("349,394");
            coords.Add("332,420");
            coords.Add("306,406,green");
            coords.Add("292,369");
            coords.Add("290,336");
            coords.Add("287,302,red");
            coords.Add("291,270");
            coords.Add("291,238");
            coords.Add("290,205");
            coords.Add("313,183");
            coords.Add("340,178");
            coords.Add("374,176");
            coords.Add("405,173");
            coords.Add("438,175,red");
            coords.Add("467,175");
            coords.Add("496,181");
            coords.Add("523,186");
            coords.Add("552,194,red");
            coords.Add("573,216");
            coords.Add("587,250");
            coords.Add("597,283");
            coords.Add("599,314,green");
            coords.Add("598,346");
            coords.Add("602,377");
            coords.Add("607,410,red");
            coords.Add("607,445");
            coords.Add("606,472");
            coords.Add("599,501");
            coords.Add("586,532,green");
            coords.Add("617,534");
            coords.Add("639,505");
            coords.Add("657,480");
            coords.Add("667,454,");
            coords.Add("673,426");
            coords.Add("684,399");
            coords.Add("689,372,red");
            coords.Add("689,344");
            coords.Add("689,344");
            coords.Add("686,311");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if(currentroll>4)
            {
                switch(currentroll) 
                { 
                case 1:playerposblue=playerposchange(playerposblue,rollthedice()); break;
                    case 2: playerpospurple = playerposchange(playerpospurple, rollthedice()); break;
                    case 3: playerposyellow = playerposchange(playerposyellow, rollthedice()); break;
                    case 4: playerposbrown = playerposchange(playerposbrown, rollthedice()); break;
                }
                currentroll++;
            }
            else
            {
                currentroll = 1;
                switch (currentroll)
                {
                    case 1: playerposblue = playerposchange(playerposblue, rollthedice()); break;
                    case 2: playerpospurple = playerposchange(playerpospurple, rollthedice()); break;
                    case 3: playerposyellow = playerposchange(playerposyellow, rollthedice()); break;
                    case 4: playerposbrown = playerposchange(playerposbrown, rollthedice()); break;
                }
                currentroll++;
            }
           
        }
        public int rollthedice()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int dice1 = rnd.Next(1,7);
       
            int dice2 = rnd2.Next(1, 7);
            
            int dicecount=dice1+dice2;

            return dicecount;
        }
         public int playerposchange(int playerpos,int dicecount)
         {
            playerpos += dicecount;

         
            return playerpos;
         }

            
    }
}