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
using System.Windows.Threading;
using System.Threading;

namespace Sammensat_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            if (!tama.tamaIsAlive)
            {
                tamaHappinessStatus.Content = 100;
                tamaHungerStatus.Content = 100;
                tamaThirstStatus.Content = 100;


            }

            tama.UpdateStats();
            SetTimer();
            
        }
        //Function for containing the status message            
        public void tamaMessageStatus(string tamaMessage)
        {
            tamaStatusMessage.Content = tamaMessage;
        }

        //function for calling printing the message only if no other stat is equal. This one is based on the HP int, so as long as the hp isn't the same as the others the message will print
        //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat hp should be at for that message
        public void tamaHPfunction(string tamaMessage, int tamaPlaceHolderNumber)
        {
            if (!(tama.tamaThirst == tamaPlaceHolderNumber && tama.tamaHunger == tamaPlaceHolderNumber && tama.tamaHappiness == tamaPlaceHolderNumber))
            {
                tamaMessageStatus(tamaMessage);
            }
            else
            {

            }
        }

        //function for calling printing the message only if no other stat is equal. This one is based on the Hunger int, so as long as the Hunger isn't the same as the others the message will print
        //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Hunger should be at for that message
        public void tamaHungerfunction(string tamaMessage, int tamaPlaceHolderNumber)
        {
            if (!(tama.tamaThirst == tamaPlaceHolderNumber && tama.tamaHunger == tamaPlaceHolderNumber && tama.tamaHappiness == tamaPlaceHolderNumber))
            {
                tamaMessageStatus(tamaMessage);
            }
            else
            {

            }
        }

        //function for calling printing the message only if no other stat is equal. This one is based on the Happiness int, so as long as the Happiness isn't the same as the others the message will print
        //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Happiness should be at for that message
        public void tamaHappinessfunction(string tamaMessage, int tamaPlaceHolderNumber)
        {
            if (!(tama.tamaThirst == tamaPlaceHolderNumber && tama.tamaHunger == tamaPlaceHolderNumber && tama.tamaHealth == tamaPlaceHolderNumber))
            {
                tamaMessageStatus(tamaMessage);
            }
            else
            {

            }
        }

        //function for calling printing the message only if no other stat is equal. This one is based on the Thirst int, so as long as the Thirst isn't the same as the others the message will print
        //tamaStatusMessage is the message you want it to write. tamaPlaceHolderNumber is the stat Thirst should be at for that message
        public void tamaThirstfunction(string tamaMessage, int tamaPlaceHolderNumber)
        {
            if (!(tama.tamaHealth == tamaPlaceHolderNumber && tama.tamaHunger == tamaPlaceHolderNumber && tama.tamaHappiness == tamaPlaceHolderNumber))
            {
                tamaMessageStatus(tamaMessage);
            }
            else
            {

            }
        }
        

        //Switch case for the messages that is printed according to hp
        public void TamaSwitchCases()
        {
            switch (tama.tamaHealth)
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
            switch (tama.tamaHappiness)
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
            switch (tama.tamaHunger)
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
            switch (tama.tamaThirst)
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
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public void SetTimer()
        {
            
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(2000);
            if (tama.tamaHealth > 1 && tama.tamaHunger > 1 && tama.tamaHappiness > 1 && tama.tamaThirst > 1 && tama.tamaThirst > 1)
            {
                dispatcherTimer.Start();
            }          
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {            
            tama.UpdateStats();
            tamaHealth.Content = tama.tamaHealth;
            tamaHungerStatus.Content = tama.tamaHunger;
            tamaHappinessStatus.Content = tama.tamaHappiness;
            tamaThirstStatus.Content = tama.tamaThirst;
            TamaSwitchCases();
            //CommandManager.InvalidateRequerySuggested();
        }

        Tama tama = new Tama(100, 100, 100, 100, true);

        /*
                    int tamaHealth = 100;
                    int tamaHappiness = 100;
                    int tamaHunger = 100;
                    int tamaThirst = 100;
                    bool tamaIsAlive = true;
        */


        // Update Tama's stat display
        public void Update()
        {
            tamaHappinessStatus.Content = tama.tamaHappiness;
            tamaHungerStatus.Content = tama.tamaHunger;
            tamaThirstStatus.Content = tama.tamaThirst;


            if (tama.tamaHealth < 0)
            {
                tama.tamaIsAlive = false;
            }
        }

        async void DelayMessage()
        {
            await Task.Delay(5000);
            tamaMessage.Content = "";
        }

        // Clicked on the button to play with Tama
        // Clicked on the button to play with Tama
        private void tamaButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            var soundPlayer = new System.Media.SoundPlayer();
            // If Tama is still alive
            if (tama.tamaIsAlive && tama.tamaHunger >= 5 && tama.tamaThirst >= 10)
            {
                
                // Tama gets hungry and thirsty from playing
                tama.tamaHunger -= 5;
                tama.tamaThirst -= 10;

                // If Tama is extremely unhappy
                if (tama.tamaHappiness <= 10)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tama.tamaHappiness += 30;
                    tamaMessage.Content = "Oh, I still exist in your world, do I?";
                }
                // If Tama is very unhappy
                else if (tama.tamaHappiness < 30)
                {

                    tamaMessage.Content = "Finally some play time...";
                    tama.tamaHappiness += 20;
                }
                // If Tama is happy-ish
                else if (tama.tamaHappiness < 50)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "It's been a while since we last played, yay!";
                    tama.tamaHappiness += 15;
                }
                // If Tama is happy
                else if (tama.tamaHappiness < 75)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "Let's play tag again!";
                    tama.tamaHappiness += 10;
                }
                // If Tama is very happy
                else if (tama.tamaHappiness <= 90)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I love when we play!";
                    tama.tamaHappiness += 10;
                }
                // If Tama is extremely happy
                else
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I'm always ready to play!";
                }
            }
            else if (tama.tamaIsAlive && tama.tamaHunger < 5 || tama.tamaThirst < 10)
            {
                soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                soundPlayer.Play();
                tamaMessage.Content = "I don't have the energy for this...";
            }
            // If Tama is dead
            else
            {
                soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                soundPlayer.Play();
                tamaMessage.Content = "I'm dead, yo.";
            }
            Update();
            DelayMessage();
        }

        // Clicked on the button to feed Tama
        private void tamaButtonFeed_Click(object sender, RoutedEventArgs e)
        {
            var soundPlayer = new System.Media.SoundPlayer();  
            // If Tama is still alive
            if (tama.tamaIsAlive)
            {
                              
                // If Tama is extremely hungry
                if (tama.tamaHunger <= 10)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tama.tamaHunger += 30;
                    tamaMessage.Content = "I was about to starve, you demon!";                    
                    
                }
                // If Tama is very hungry
                else if (tama.tamaHunger < 30)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I was so hungry...";
                    tama.tamaHunger += 20;
                }
                // If Tama is peckish
                else if (tama.tamaHunger < 50)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "Woo, food!";
                    tama.tamaHunger += 15;
                }
                // If Tama is moderately full
                else if (tama.tamaHunger < 75)
                {

                    tamaMessage.Content = "I recently ate, but I can eat more.";
                    tama.tamaHunger += 10;
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                }
                // If Tama is very full
                else if (tama.tamaHunger < 90)
                {

                    tamaMessage.Content = "I can't eat anymore...";
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                    soundPlayer.Play();
                    // Only decrease happiness if it wouldn't get below 0
                    if (tama.tamaHappiness >= 5)
                    {
                        soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                        soundPlayer.Play();
                        tama.tamaHappiness -= 5;
                    }
                }
                // If Tama is too full
                else
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "There's no way I can eat anymore!";

                    // Only decrease happiness if it wouldn't get below 0
                    if (tama.tamaHappiness >= 10)
                    {
                        soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                        soundPlayer.Play();
                        tama.tamaHappiness -= 10;
                    }
                }

            }
            else if (tama.tamaIsAlive && tama.tamaHappiness < 10)
            {
                soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                soundPlayer.Play();
                tamaMessage.Content = "There's no way I can eat anymore!";
            }
            // If Tama is dead
            else
            {
                soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                soundPlayer.Play();
                tamaMessage.Content = "I'm dead, yo.";
            }
            Update();
            DelayMessage();
        }


        // Clicked on the button to refill Tama's water bowl
        private void tamaButtonWater_Click(object sender, RoutedEventArgs e)
        {
            var soundPlayer = new System.Media.SoundPlayer();    
            // If Tama is still alive
            if (tama.tamaIsAlive)
            {

                // If Tama is extremely thirsty
                if (tama.tamaThirst <= 10)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tama.tamaThirst += 30;
                    tamaMessage.Content = "I was about to die of thirst, you demon!";
                }
                // If Tama is very thirsty
                else if (tama.tamaThirst < 30)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I was so thirsty...";
                    tama.tamaThirst += 20;
                }
                // If Tama is slightly thirsty
                else if (tama.tamaThirst < 50)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "Woo, water!";
                    tama.tamaThirst += 15;
                }
                // If Tama is hydrated
                else if (tama.tamaThirst < 75)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I can always drink some water.";
                    tama.tamaThirst += 10;
                }
                // If Tama is very hydrated
                else if (tama.tamaThirst < 90)
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\good.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "I can't drink anymore...";

                    // Only decrease happiness if it wouldn't get below 0
                    if (tama.tamaHappiness >= 5)
                    {
                        soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                        soundPlayer.Play();
                        tama.tamaHappiness -= 5;
                    }
                }
                // If Tama is too hydrated
                else
                {
                    soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                    soundPlayer.Play();
                    tamaMessage.Content = "There's no way I can drink anymore!";

                    // Only decrease happiness if it wouldn't get below 0
                    if (tama.tamaHappiness >= 10)
                    {
                        soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                        soundPlayer.Play();
                        tama.tamaHappiness -= 10;
                    }
                }
                
            }
            // If Tama is dead
            else
            {
                soundPlayer.SoundLocation = @"C:\Users\shan0382\source\repos\Sammensat app\Sammensat app\bad.wav";
                soundPlayer.Play();
                tamaMessage.Content = "I'm dead, yo.";
            }
            Update();
            DelayMessage();
        }
    }
}
