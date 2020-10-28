using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tamagotchi_status
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///     
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();

            tamaStats tamagotchi = new tamaStats();
            
            //Function for containing the status message            
            void tamaMessageStatus(string tamaMessage)
            {
                tamaStatusMessage.Content = tamaMessage;
            }

            //function for calling printing the message only if no other stat is equal. This one is based on the HP int, so as long as the hp isn't the same as the others the message will print
            //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat hp should be at for that message
            void tamaHPfunction(string tamaMessage, int tamaPlaceHolderNumber)
            {
                if (!(tamagotchi.tamaThirst == tamaPlaceHolderNumber && tamagotchi.tamaHunger == tamaPlaceHolderNumber && tamagotchi.tamaHappiness == tamaPlaceHolderNumber))
                {
                    tamaMessageStatus(tamaMessage);
                }
                else
                {

                }
            }

            //function for calling printing the message only if no other stat is equal. This one is based on the Hunger int, so as long as the Hunger isn't the same as the others the message will print
            //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Hunger should be at for that message
            void tamaHungerfunction(string tamaMessage, int tamaPlaceHolderNumber)
            {
                if (!(tamagotchi.tamaThirst == tamaPlaceHolderNumber && tamagotchi.tamaHunger == tamaPlaceHolderNumber && tamagotchi.tamaHappiness == tamaPlaceHolderNumber))
                {
                    tamaMessageStatus(tamaMessage);
                }
                else
                {
                    
                }
            }

            //function for calling printing the message only if no other stat is equal. This one is based on the Happiness int, so as long as the Happiness isn't the same as the others the message will print
            //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Happiness should be at for that message
            void tamaHappinessfunction(string tamaMessage, int tamaPlaceHolderNumber)
            {
                if (!(tamagotchi.tamaThirst == tamaPlaceHolderNumber && tamagotchi.tamaHunger == tamaPlaceHolderNumber && tamagotchi.tamaHP == tamaPlaceHolderNumber))
                {
                    tamaMessageStatus(tamaMessage);
                }
                else
                {

                }
            }

            //function for calling printing the message only if no other stat is equal. This one is based on the Thirst int, so as long as the Thirst isn't the same as the others the message will print
            //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Thirst should be at for that message
            void tamaThirstfunction(string tamaMessage, int tamaPlaceHolderNumber)
            {
                if (!(tamagotchi.tamaHP == tamaPlaceHolderNumber && tamagotchi.tamaHunger == tamaPlaceHolderNumber && tamagotchi.tamaHappiness == tamaPlaceHolderNumber))
                {
                    tamaMessageStatus(tamaMessage);
                }
                else
                {

                }
            }
                        
            //Switch case for the messages that is printed according to hp
            switch (tamagotchi.tamaHP)
            {
                case 80:
                    tamaHPfunction("fuck off ya twat", 80);
                    break;
                case 40:
                    tamaHPfunction("I doubt a bandage will fix this one", 40);
                    break;
                case 30:
                    tamaHPfunction("Ooof", 30);
                    break;
                case 25:
                    tamaHPfunction("Hello darkness my old friend", 25);
                    break;
                case 20:
                    tamaHPfunction("Welp", 20);
                    break;
                case 15:
                    tamaHPfunction("Excuse me. I'm hurting over here", 15);
                    break;
                case 10:
                    tamaHPfunction("Bruh", 10);
                    break;
                case 5:
                    tamaHPfunction("I'm dyin over here!", 5);
                    break;
                case 0:
                    tamaHPfunction("I died, why would you hurt me this way?", 0);
                    break;

                default:
                    break;
            }
            //Switch case for the messages that is printed according to happiness
            switch (tamagotchi.tamaHappiness)
            {
                case 80:
                    tamaHappinessfunction("Pink fluffy unicorns dancing on rainbows!", 80);
                    break;
                case 40:
                    tamaHappinessfunction("Fluffy unicorns doesn't sound that good right now", 40);
                    break;
                case 30:
                    tamaHappinessfunction("Hello darkness my old friend", 30);
                    break;
                case 25:
                    tamaHappinessfunction("Depression might be sliding in my dm's soon", 25);
                    break;
                case 20:
                    tamaHappinessfunction("Is this how it ends?", 20);
                    break;
                case 15:
                    tamaHappinessfunction("Well, i didn't expect anything less from you", 15);
                    break;
                case 10:
                    tamaHappinessfunction("Come on ya twat, let's have some fun!", 10);
                    break;
                case 5:
                    tamaHappinessfunction("I hope you are proud of yourself", 5);
                    break;
                case 0:
                    tamaHappinessfunction("I'll see you in hell", 0);
                    break;
                default:
                    break;
            }
            //Switch case for the messages that is printed according to hunger
            switch (tamagotchi.tamaHunger)
            {
                case 80:
                    tamaHungerfunction("I think i can still go for a slice of cake", 80);
                    break;
                case 40:
                    tamaHungerfunction("Feed me you uncultured swine", 40);
                    break;
                case 30:
                    tamaHungerfunction("I'm about to be really hangry if you don't feed me soon", 30);
                    break;
                case 25:
                    tamaHungerfunction("Hello? Can you hear the sound of my tummy rumbling?", 25);
                    break;
                case 20:
                    tamaHungerfunction("I'm getting quite hungry. Feed me ya bitch", 20);
                    break;
                case 15:
                    tamaHungerfunction("My tummy is rumbling", 15);
                    break;
                case 10:
                    tamaHungerfunction("I don't have any survival instincs, please feed me", 10);
                    break;
                case 5:
                    tamaHungerfunction("I'm really close to dying of hunger, can you please help?", 5);
                    break;
                case 0:
                    tamaHungerfunction("Why do you do this?", 0);
                    break;
                default:
                    break;
            }
            //Switch case for the messages that is printed according to thirst
            switch (tamagotchi.tamaThirst)
            {
                case 80:
                    tamaThirstfunction("Anybody got a milkshake?", 80);
                    break;
                case 40:
                    tamaThirstfunction("I could really go for a glass of water right now", 40);
                    break;
                case 30:
                    tamaThirstfunction("Enough aboout hunger, i'm getting really thirsty", 30);
                    break;
                case 25:
                    tamaThirstfunction("Can you please pass me the water?", 25);
                    break;
                case 20:
                    tamaThirstfunction("What i wouldn't do to get some fresh water", 20);
                    break;
                case 15:
                    tamaThirstfunction("This thirst is killing me..", 15);
                    break;
                case 10:
                    tamaThirstfunction("I can barely survive 2 more hours at this rate..", 10);
                    break;
                case 5:
                    tamaThirstfunction("I'm getting really neasous, i'll die if i don't get to drink anything soon", 5);
                    break;
                case 0:
                    tamaThirstfunction("Why. Just why?", 0);
                    break;
                default:
                    break;
            }
            
            }
            public class tamaStats
            {
                //Tamagotchi stats. Set at 100 as standard
                public int tamaHP = 100;
                public int tamaHappiness = 100;
                public int tamaHunger = 100;
                public int tamaThirst = 100;
            }
        }
}
