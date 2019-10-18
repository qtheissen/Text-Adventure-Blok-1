using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour{

    public delegate void TestDelegate(); // This defines what type of method you're going to call.
    public TestDelegate FunctionToCall; // Container voor een functie

    // States houd bij welk moment de speler
    private enum States{
       mainmenu,
       credits,
       intro1,
       call,
       intro2,
       coin,
       death_well,
       floodedhall,
       threwstone,
       death_seamonster1,
       seamonster,
       death_seamonster2,
       watersurface,
       underwater,
       seamonster_kill,
       onrock,
       death_seamonster3,
       seamonster_kill_secret,



       
    }

    // Als WrongInputState True is dan moet de speler eerst een random input doen om verder te kunnen met het spel
    private bool WrongInputState = false;

    // Houd bij of de speler de coin in de well heeft gegooid
    private bool DidCoin = false;
    
    // Deze variabele houd de huidige state van de game bij
    private States currentState = States.mainmenu;


    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    

    void OnUserInput(string input){
        if (WrongInputState == false){
            switch(currentState){
                
                //TEMPlATE NEW CASE
                //----------------------------------------------------------------------
                /*
                case States.xxxxxx:
                    if (input == "XXXXXX"){
                        FUNCTION();
                    }
                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = ShowMainMenu;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = FUNCTION;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;
                 */

                //main menu
                case States.mainmenu:
                    if (input == "start"){
                        StartIntro1();
                    }
                    else if (input == "credits"){
                        ShowCredits();
                    }
                    else if (input == ""){
                        //als de speler alleen maar op enter (niks intypt) drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = ShowMainMenu;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = ShowMainMenu;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.credits:
                    if (input == "back"){
                        ShowMainMenu();
                    }
                    
                    else if (input == ""){
                        //als de speler alleen maar op enter (niks intypt) drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = ShowCredits;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = ShowCredits;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                //intro part 1
                case States.intro1:
                    if (input == "look"){
                        StartIntro2();
                    }

                    else if (input == "call"){
                        StartCall();
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartIntro1;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartIntro1;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                //intro part 2
                 case States.intro2:
                    if (input == "well"){
                        StartDeathWell();
                    }

                    else if (input == "arch"){
                        StartFloodedHall();
                    }

                    else if (input == "coin"){
                        StartCoin();
                        DidCoin = true;
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartIntro2;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartIntro2;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }

                
                break;
                case States.call:
                    if (input == "look"){
                        StartIntro2();
                    }


                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartCall;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartCall;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }

                
                break;
                //death well
                case States.death_well:
                    if (input == "retry"){
                            ShowMainMenu();
                    }
                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartDeathWell;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartDeathWell;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.coin:

                
                    if (input == "arch"){
                        StartFloodedHall();
                    }

                    else if (input == "well"){
                        StartDeathWell();
                        
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartCoin;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartCoin;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.floodedhall:
                    
                    if (input == "rock"){
                        StartThrewStone();
                    }

                    else if (input == "boat"){
                        StartSeamonster();
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartFloodedHall;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartFloodedHall;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.threwstone:
                    
                    if (input == "boulder"){
                        StartDeathSeamonster1();
                    }

                    else if (input == "boat"){
                        StartSeamonster();
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartThrewStone;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartThrewStone;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }   
                break;

                case States.death_seamonster1:
                    
                    if (input == "retry"){
                        ShowMainMenu();
                    }


                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartDeathSeamonster1;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartDeathSeamonster1;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }     
                break;

                case States.seamonster:
                    
                    if (input == "stay"){
                        StartDeathSeamonster2();
                    }

                    else if (input == "jump"){
                        StartWatersurface();
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartSeamonster;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartSeamonster;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.death_seamonster2:
                     if (input == "retry"){
                            ShowMainMenu();
                    }
                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartDeathSeamonster2;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartDeathSeamonster2;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.watersurface:
                    
                    if (input == "dive"){
                        StartUnderwater();
                    }

                    else if (input == "rock"){
                        StartOnrock();
                    }

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartWatersurface;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartWatersurface;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.onrock:
                    
                    if (input == "attack"){
                        if(DidCoin == false){
                            StartDeathSeamonster3();
                        }
                        else if(DidCoin == true){
                            StartSeamonsterKillSecret();
                        }
                    }

                

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartOnrock;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartOnrock;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                 case States.underwater:
                    
                    if (input == "drain"){
                        StartSeamonsterKill();
                    }

                

                    else if (input == ""){
                        //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                        FunctionToCall = StartUnderwater;
                        WrongInput(FunctionToCall);
                    }
                    else{
                        // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                        // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                        FunctionToCall = StartUnderwater;
                        WrongInputState = true;
                        Terminal.ClearScreen();
                        Terminal.WriteLine("Wrong input, press enter to continue");
                    }
                break;

                case States.seamonster_kill:
                        if (input == "retry"){
                            ShowMainMenu();
                        }
                        else if (input == ""){
                            //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                            FunctionToCall = StartSeamonsterKill;
                            WrongInput(FunctionToCall);
                        }
                        else{
                            // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                            // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                            FunctionToCall = StartSeamonsterKill;
                            WrongInputState = true;
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Wrong input, press enter to continue");
                        }
                break;

                case States.seamonster_kill_secret:
                        if (input == "retry"){
                            ShowMainMenu();
                        }
                        else if (input == ""){
                            //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                            FunctionToCall = StartSeamonsterKillSecret;
                            WrongInput(FunctionToCall);
                        }
                        else{
                            // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                            // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                            FunctionToCall = StartSeamonsterKillSecret;
                            WrongInputState = true;
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Wrong input, press enter to continue");
                        }
                break;

                case States.death_seamonster3:
                        if (input == "retry"){
                            ShowMainMenu();
                        }
                        else if (input == ""){
                            //als de speler alleen maar op enter drukt is het niet nodig om ze door het hele WrongInput menu te halen
                            FunctionToCall = StartDeathSeamonster3;
                            WrongInput(FunctionToCall);
                        }
                        else{
                            // FunctionToCall vertelt de code naar welke functie de speler teruggestuurd moet worden
                            // in het geval dat ze een foute input geven en naar het WrongInputState menu gestuurd worden
                            FunctionToCall = StartDeathSeamonster3;
                            WrongInputState = true;
                            Terminal.ClearScreen();
                            Terminal.WriteLine("Wrong input, press enter to continue");
                        }
                break;
            }
        }
        // als de WrongInputState true is dan moet de speler op enter drukken
        //(of iets randoms invoeren en dan op enter drukken) om het spel verder te laten gaan
        // dit moeten ze doen voordat ze een correcte input geven
        else if (WrongInputState == true){

            //de speler hoort deze if statement niet te kunnen voltooien, en deze if statement is bedoelt om altijd op de else uit te komen
            if(input == "8206209105760109857029835710984019248"){
                Terminal.WriteLine("Congrats you just managed to break the game");
            }
            //als deze else statement uitgevoerd wordt dan stuurt de game de speler met een functie terug naar het juiste moment in het spel
            else{
                WrongInput(FunctionToCall);
                
                WrongInputState = false;
            }
            
        }
    
        
    }
    //stuurt de speler vanuit de WrongInputState terug naar de het juiste moment, door de bijbehorende functie te activeren.
    void WrongInput(TestDelegate function){
        
        function();
            
    }
    //wordt door de start functie aangeroepen aan het begin van het spel
     void ShowMainMenu(){
        currentState = States.mainmenu;
        DidCoin = false;
        Terminal.ClearScreen();
        Terminal.WriteLine("_-_-_-DROWNED-_-_-_");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");
        Terminal.WriteLine("start - Start the game");
        Terminal.WriteLine("credits - View the credits");

        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

    void retry(){
        DidCoin = false;
        ShowMainMenu();
    }

    void ShowCredits(){
        currentState = States.credits;
        Terminal.ClearScreen();
        Terminal.WriteLine("_-_-_-CREDITS-_-_-_");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("CODING: Quint Theissen");
        Terminal.WriteLine("ART: Quint Theissen");
        Terminal.WriteLine("");
        Terminal.WriteLine("FONT: dafont.com");
        Terminal.WriteLine("");
        Terminal.WriteLine("DOCENT & MENTOR: Dennis van Wakeren");
        
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("back - Go back to the main menu");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

    //eerste intro van het spel
    void StartIntro1(){
        currentState = States.intro1;
        Terminal.ClearScreen();
        Terminal.WriteLine("You wake up lying on the cold hard stone ground of a dusty, ornate room, lit only by a dim light emitting from a hole in the ceiling.");
        Terminal.WriteLine("");
        Terminal.WriteLine("The last thing you remember is your small ship sinking in the midst of a heavy storm.");
        Terminal.WriteLine("As your head clears you start to wonder how the hell you got here.");
        Terminal.WriteLine("'Who or what brought me here?' You ask yourself, as you get up from the floor.");
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("call - Call out in the hope that someone responds");
        Terminal.WriteLine("look - Inspect the room, and see if there is a way out");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartCall(){
        currentState = States.call;
        Terminal.ClearScreen();
        Terminal.WriteLine("'Is anyone there!?', You scream loudly, only to be met again by your own echoing voice.");
        Terminal.WriteLine("It seems like you are all by yourself in this strange place...");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("look - Inspect the room, and see if there is a way out");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartIntro2(){
        currentState = States.intro2;
        Terminal.ClearScreen();
        Terminal.WriteLine("Instinctively you reach for your pockets, the only thing you find is a heavy golden coin.");
        Terminal.WriteLine("The rest of your belongings seem to have gone lost during the storm");
        Terminal.WriteLine("It seems you were sleeping next to some sort of well, placed in the middle of the round-shaped room.");
        Terminal.WriteLine("Placed over the well is the faint light you just saw, you can only assume it is daylight from the surface.");
        Terminal.WriteLine("Upon further inspection of the room you see a tall archway leading into a long and broad hall.");
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("well - Jump into the seemingly bottomless well");
        Terminal.WriteLine("arch - Enter the archway");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartDeathWell(){
        currentState = States.death_well;
        Terminal.ClearScreen();
        Terminal.WriteLine("In a fit of pure stupidity you decide to jump into the well.");
        Terminal.WriteLine("You climb over the edge of the well and plunge into the depth.");
        Terminal.WriteLine("After about 2 seconds of falling you hit the ground, with a loud metalic CLUNK!");
        Terminal.WriteLine("While your broken legs bleed out, you notice you fell on a pile of coins.");
        Terminal.WriteLine("As you draw your last breath you think to yourself: 'Did i really think i was going to accomplish anything by jumping into a well?'");
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------YOU DIE-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("retry - Try the game again from the beginning");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartCoin(){
        currentState = States.coin;
        Terminal.ClearScreen();
        Terminal.WriteLine("You walk towards the well and throw the golden coin in, thinking it might bring good fortune.");
        Terminal.WriteLine("2 seconds later you hear the coin landing on what seems like a metal surface");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");

        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("well - You regret throwing away your last possession and decide to pursue it down the well");
        Terminal.WriteLine("arch - Walk away and enter the archway, as a sane person would");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

     void StartFloodedHall(){
        currentState = States.floodedhall;
        Terminal.ClearScreen();
        Terminal.WriteLine("You walk towards and then under the archway.");
        Terminal.WriteLine("Beyond the archway lies an enormous flooded hall, with 2 collumns of pillars going forward.");
        Terminal.WriteLine("The entire lower half of the hall is flooded with murky water, with only the entrance of the hall remaining unsubmerged.");
        Terminal.WriteLine("Where the water meets the entrance of the hall you spot a shabby looking wooden rowboat. Next to it a pile of rocks.");
        Terminal.WriteLine("");
        Terminal.WriteLine("");

        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("boat - You decide to lower the boat into the water, to further explore the hall");
        Terminal.WriteLine("rock - Throw a rock into the water, incase anything lurks down there");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartThrewStone(){
        currentState = States.threwstone;
        Terminal.ClearScreen();
        Terminal.WriteLine("You grab a fist sized rock and throw it into the murky water.");
        Terminal.WriteLine("As the once calm water gets disturbed by the impact of the rock, so does whatever lies under the water, as you hear a faint rumble.");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");

        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("boat - You lower the boat into the water, careful not to disturb what lies below");
        Terminal.WriteLine("boulder - Hurl a larger boulder into the water, curious as to what lies below");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartDeathSeamonster1(){
        currentState = States.death_seamonster1;
        Terminal.ClearScreen();
        Terminal.WriteLine("After hurling the boulder into the water with a loud plunge, it stays completely silent for a moment.");
        Terminal.WriteLine("Suddenly something that you can only describe as an eldritch horror arises from the water!");
        Terminal.WriteLine("In complete shock you gaze upon its monstrous appearance, as it picks you up with a fel swoop of one of its tentacles.");
        Terminal.WriteLine("You take your last gulp of air before it drags you into the depths.");
        Terminal.WriteLine("Unable to breathe and move your lungs fill themselves with water");
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------YOU DIE-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("retry - Try the game again from the beginning");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

     void StartSeamonster(){
        currentState = States.seamonster;
        Terminal.ClearScreen();
        Terminal.WriteLine("With little effort you push the boat into the water.");
        Terminal.WriteLine("As you wade through the now knee-deep water, pushing the boat along with you, you cant help but be surprised it even stays afloat.");
        Terminal.WriteLine("You get into the boat, grab a paddle, and start rowing out into the hall.");
        Terminal.WriteLine("After passing a few pillars you spot a rock illuminated by a beam of light.");
        Terminal.WriteLine("Atop the rock sit the remains of a person, holding a rusty sword. The sight sends chills down you spine.");
        Terminal.WriteLine("When you are about halfway through the hall you feel your paddle hitting something, followed by a loud unnatural growling noise.");
        Terminal.WriteLine("You hang over the edge of your rowboat, and stare into the deep murky water only to see a huge eye stare back at you");
        Terminal.WriteLine("As you back away a gargantuan creature emerges from the foul water, with its hundreds of eyes pointed straight at you and your boat!");
        //empty line voor keuzes
        
        Terminal.WriteLine("-------COMMANDS-------");
        

        Terminal.WriteLine("stay - Steer the boat away and try to escape the beast");
        Terminal.WriteLine("jump - Jump into the water and leave your boat behind");

        //empty line voor player input
        
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartDeathSeamonster2(){
        currentState = States.death_seamonster2;
        Terminal.ClearScreen();
        Terminal.WriteLine("The beast raises one of its limbs and brings it down upon you and your boat, the force is great enough to throw you off of your boat,");
        Terminal.WriteLine("With your back broken you slowly sink into the depths, unable to swim back up.");
        
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------YOU DIE-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("retry - Try the game again from the beginning");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

    void StartWatersurface(){
        currentState = States.watersurface;
        Terminal.ClearScreen();
        Terminal.WriteLine("You jump out of your boat, nearly dodging a powerful strike. You hear your boat breaking behind you");
        Terminal.WriteLine("In your panic you only now notice that you are but a few feet away from the rock with the sword.");
        Terminal.WriteLine("You might be able to make it there.");
        
        
      
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("rock - Swim to the rock");
        Terminal.WriteLine("dive - Dive down and try to hide from the beast");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartUnderwater(){
        currentState = States.underwater;
        Terminal.ClearScreen();
        Terminal.WriteLine("You take a deep breath before diving down into the water, swimming down as deep as you can.");
        Terminal.WriteLine("The beast hasn't grabbed you yet, you have bought yourself some time.");
        Terminal.WriteLine("As you hit the hall of the floor, you feel around and find what seems to be a drain.");
        
        
      
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("drain - Pull iron chain connected to the drain");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   
     void StartSeamonsterKill(){
        currentState = States.seamonster_kill;
        Terminal.ClearScreen();
        Terminal.WriteLine("With all your strength you pull the iron chain, and after a few tugs the drain slips loose.");
        Terminal.WriteLine("As you hold your breath the drain keeps sucking water in, just as your lungs are filling up with water all the water has been drained from the hall.");
        Terminal.WriteLine("After coughing up a whole lot of water you see the horrendous creature laying lifeless on the freshly drained floor.");
        Terminal.WriteLine("The drained hall reveals what looks to be an exit, finally, a way out of this place!");
        
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------VICTORY-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("Congratulations, you just won the game! If you want to try to win the game again, perhaps in a different way, type retry.");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

    void StartOnrock(){
        currentState = States.onrock;
        Terminal.ClearScreen();
        Terminal.WriteLine("You swim faster then you have ever before, when you get to the rock, after what feels like ages,");
        Terminal.WriteLine("You climb up the rock and grab the rusty blade, only to realise you have never held a sword before.");
        Terminal.WriteLine("Just as you get your hands on the blade the beast makes it way over to you, trembling on your feet you raise your sword up in the air.");
        
        
      
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------COMMANDS-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("attack - Lunge your sword at the beast and hope for the best");

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }   

    void StartDeathSeamonster3(){
        currentState = States.death_seamonster3;
        Terminal.ClearScreen();
        Terminal.WriteLine("You swing your blade at the beast, but the blade scrapes off of its thick hide.");
        Terminal.WriteLine("Realizing you have lost this battle, you drop your sword and cower on the rock, to then be turned into mush on said rock.");
        
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------YOU DIE-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("retry - Try the game again from the beginning");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }

    void StartSeamonsterKillSecret(){
        currentState = States.seamonster_kill_secret;
        Terminal.ClearScreen();
        Terminal.WriteLine("The creature aggresively lunges itself toward you, you expect to die any moment now, but the monster practically threw itself on your sword.");
        Terminal.WriteLine("With a roar earthshatteringly loud, the monster sinks back into the water, leaving behind a gigantic pool of black blood, mixing with the vile water.");
        Terminal.WriteLine("With your sword still in hand, the light shining upon the rock grows brighter and brighter, until it becomes so unbearably bright you pass out.");
        Terminal.WriteLine("");
        Terminal.WriteLine("You wake up on a grey beach, amongst the remains of your wrecked ship.");
        
        
        //empty line voor keuzes
        Terminal.WriteLine("");
        Terminal.WriteLine("-------SECRET VICTORY-------");
        Terminal.WriteLine("");

        Terminal.WriteLine("Congratulations, you just accomplished the secret victory! To play the game again type retry");
        

        //empty line voor player input
        Terminal.WriteLine("");
        Terminal.WriteLine("----------------------");
        Terminal.WriteLine("");
    }
}
