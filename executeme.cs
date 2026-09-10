/* ============================================================================
 * CREDITS & HOMAGE
 * 
 * This is a creative, console-based interactive adaptation of:
 * Song: "World.execute(me);"
 * Artist: Mili
 * Lyrics: Cassie Wei
 * Composition: Yamato Kasai / Mili
 *
 * Original Work: Copyright © Mili. All rights reserved.
 (I just love Mili so damn much)
 * ============================================================================
 */

#nullable disable
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic; 
using System.Runtime.InteropServices; 
using NAudio.Wave;
using NAudio.CoreAudioApi;
ref int systemCorruptionLevel = ref ScriptRuntimeEnvironment.systemCorruptionLevel;
ScriptRuntimeEnvironment.UseCustomTerminal = true;

Console.ForegroundColor = ConsoleColor.DarkGray;
string targetCommand = "world.execute(me);";
string userTyped = "";
string errorMessage = "";

NAudio.Wave.WaveOutEvent wavePlayer = null;
NAudio.Wave.AudioFileReader audioReader = null;
string audioFilePath = @"C:\Users\Punsu\My_Stash\WorldExecute.Me\World.execute(me).mp3";
float chosenVolume = 0.5f;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Gray;

    
    string screenContentLine = $"C:\\>{userTyped}_".PadRight(41);
    
    
    string screenErrorLine = string.IsNullOrEmpty(errorMessage) ? new string(' ', 41) : errorMessage.PadRight(41);

    Console.WriteLine("        [Terminal Initialized. Awaiting system initiation command...]");
    Console.WriteLine(@"             ________________________________________________");
    Console.WriteLine(@"            /                                                \");
    Console.WriteLine(@"           |    _________________________________________     |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.Write    (@"           |   |"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(screenContentLine); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(@"|    |");
    Console.Write    (@"           |   |"); Console.ForegroundColor = ConsoleColor.Red;   Console.Write(screenErrorLine);   Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(@"|    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |                                         |    |");
    Console.WriteLine(@"           |   |_________________________________________|    |");
    Console.WriteLine(@"           |                                                  |");
    Console.WriteLine(@"            \_________________________________________________/");
    Console.WriteLine(@"                   \___________________________________/");
    Console.WriteLine(@"                ___________________________________________");
    Console.WriteLine(@"             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_");
    Console.WriteLine(@"          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_");
    Console.WriteLine(@"       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_");
    Console.WriteLine(@"    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_");
    Console.WriteLine(@" _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_");
    Console.WriteLine(@":-------------------------------------------------------------------------:");
    Console.WriteLine(@"`---._.-------------------------------------------------------------._.---'");
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Cyan;
   
    Console.ResetColor();

    
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    if (keyInfo.Key == ConsoleKey.Enter)
    {
        if (userTyped == targetCommand)
        {
            
            errorMessage = "";
            break;
        }
        else
        {
            
            errorMessage = "Command unauthorized. Retry sequence.";
            userTyped = "";
        }
    }
    else if (keyInfo.Key == ConsoleKey.Backspace)
    {
        errorMessage = ""; 
        if (userTyped.Length > 0)
        {
            userTyped = userTyped.Substring(0, userTyped.Length - 1);
        }
    }
    else if (keyInfo.KeyChar != '\0')
    {
        errorMessage = ""; 
        
        if (userTyped.Length < 35 && userTyped.Length < targetCommand.Length)
        {
            userTyped += keyInfo.KeyChar;
        }
    }
}


Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
WriteColored("[Access Granted. Initializing world.execute(me);...]", ConsoleColor.Cyan, true);
Pause(1500);

Console.ResetColor();
Console.Clear();
Pause(1000);

if (File.Exists(audioFilePath))
{
    
    wavePlayer = new WaveOutEvent(); 
    audioReader = new AudioFileReader(audioFilePath);
    audioReader.Volume = chosenVolume; 
    wavePlayer.Init(audioReader); 
    wavePlayer.Play(); 
}


WriteColored("// Switch on the power line", ConsoleColor.DarkGray);
Pause(500);

WriteColored("// Remember to put on", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
systemCorruptionLevel = 2; 
WriteColored(" // PROTECTION", ConsoleColor.Red);
WriteColored("      ▲ ", ConsoleColor.Yellow, true); 
WriteColored("     [█]", ConsoleColor.DarkGray, true); 
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);

WriteColored("public class GodDrinksJava {", ConsoleColor.Gray, true);
Console.Out.Flush();
WriteColored(" // Lay down your pieces", ConsoleColor.DarkGray);
Pause(500);

WriteColored(" // and let's begin", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
 
systemCorruptionLevel = 4; 
WriteColored(" // OBJECT CREATION", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("  public static void main(String[] args) {", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored(@"
                    __gggrgM**M#mgggggHh(_)
                __wgNN@""B*P""""mp""""@d#""@N#N
              _g#@0F_a*F#  _*F9m_ ,F9*__9NG#g_h()
           _mN#F  aM""    #p""    !q@    9NL ""9#Qu_
          g#MF _pP""L  _g@""9L_  _g""""#___  g""9w_ 0N#p
        _0F jL*""   7_wF     #_gF     9gjF   ""bJ  9h_()
       j#  gAF    _@NL     _g@#_      J@u_    2#_  #_ppP
      ,FF_#"" 9_ _#""  ""b_  g@   ""hg  _#""  !q_ jF ""*_09_
      F N""    #p""      Ng@       `#g""      ""w@    ""# t
     j p#    g""9_     g@""9_      gP""#_     gF""q    Pb L
     0J  k _@   9g_ j#""   ""b_  j#""   ""b_ _d""   q_ g  ##                Object.Create(null);
     #F  `NF     ""#g""       ""Md""       5N#      9W""  j#
     #k  jFb_    g@""q_     _*""9m_     _*""R_    _#Np  J#
     tApjF  9g  J""   9M_ _m""    9%_ _*""   ""#  gF  9_jNF
      k`N    ""q#       9g@        #gF       ##""    #""j
      `_0q_   #""q_    _&""9p_    _g""`L_    _*""#   jAF,'
       9# ""b_j   ""b_ g""    *g _gF    9_ g#""  ""L_*""qNF
        ""b_ ""#_    ""NL      _B#      _I@     j#"" _#""
          NM_0""*g_ j""""9u_  gP  q_  _w@ ]_ _g*""F_g@
           ""NNh_ !w#_   9#g""    ""m*""   _#*"" _dN@""
              9##g_0@q__ #""4_  j*""k __*NF_g#@P""
                ""9NN#gIPNL_ ""b@"" _2M""Lg#N@F""
                    """"P@*NN#gEZgNN@#@P"" """, ConsoleColor.DarkBlue, true);
WriteColored("", ConsoleColor.DarkGray);
Console.Out.Flush();
WriteColored("     //Fill in my data parameters", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);

systemCorruptionLevel = 6; 
WriteColored("     // INITIALIZATION . . .", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     Thing me = new Lovable('Me', 0, true, -1, false);", ConsoleColor.Gray, true);
WriteColored("     Thing you = new Lovable('You', 0, false, -1, false);", ConsoleColor.Gray, true);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored(@"
                    
                    
                    [ ME ]  連結建立中... [ YOU ]
                           ", ConsoleColor.Red, true); 

WriteColored("  }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // Set up our new world", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     World world = new World(5);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.addThing(me);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.addThing(you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     // And let's begin the", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
systemCorruptionLevel = 6; 
WriteColored("     // SIMULATION", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.startSimulation();", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     Loading . . .", ConsoleColor.Gray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored(@"
        =_____________________________________________-
        |.'',                                     ,''.|
        |.'.'',                                 ,''.'.|
        |.'.'.'',                             ,''.'.'.|
        |.'.'.'.'',                         ,''.'.'.'.|
        |.'.'.'.'.|                         |.'.'.'.'.|
        |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
        |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
        |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
        |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
        |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
        |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
        |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
        |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
        |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
        |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
        |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
        |.'.','         /%%%%%%%%%%%%%\         ','.'.|
        |.','          /%%%%%%%%%%%%%%%\          ','.|
        |;____________/%%%%%%%%%%%%%%%%%\____________;|
                ", ConsoleColor.Gray, true);
WriteColored(@"
        ┌────────────────────────────────────────────────────────┐
        │  [!] SYSTEM: CONNECTING TO WORLD.SIMULATION(5); ...    │
        │  [─] LOADING DATA PARAMETERS...                        │
        └────────────────────────────────────────────────────────┘
        
        ", ConsoleColor.Gray, true);
RenderLoadingProgress("Generating 'me' and 'you'", 15000);

WriteColored("   // If I'm a set of points", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     if(me instanceof PointSet){", ConsoleColor.Gray, true);

WriteColored("     // Then I will give you my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // DIMENSION", ConsoleColor.Red);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     you.addAttribute(me.getDimensions().toAttribute());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.DarkGray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);

WriteColored("   // If I'm a circle,", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   if(me instanceof Circle){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // Then I will give you my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // CIRCUMFERENCE", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     you.addAttribute(me.getCircumference().toAttribute());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);

Pause(500);
WriteColored("   // If I'm a sine wave,", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   if(me instanceof SineWave){", ConsoleColor.Gray, true);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored(@"
  ......                                                                                            
  .:::::..                                                                                          
                                                                                                    
                                  ..::-.           ..::::..                                         
                                  ....-.         .-:..  ..:-.                                       
                                      :.       .-..        ..-.                                     
                                      :.     .::..           .::.                                   
                                      :.    .:.               ..:.                                  
                                  ....:.  ..:.                  .:..                                
                                  .:::-. ..:.                    .:..                               
                                      :. .-.                      .:..                              
                                      -..-.                        .-.                              
                                      -.-.                          .-.                             
       ..        ..         ..        --.       ..         .         .-.                            
    .:::::::::::::::::::::::::::::::::=::::::::::::::::::::::::::::::::::                           
     .-:-.      ..-:      ...-      .:-.        :.        .-         -:                             
      .::.                         .:.-.                                                            
       .::                        .::.-.                                                            
        .-:                      .::. -.                                                            
         .::                    .:-:::-:                                                            
          .::.                 .::....:.                                       ........             
           ..:.               .-..    :.                                  .............             
             .::             :-       :.                                                            
              .::..       ..-.        :.                                  ......:.:....:::.         
                 :-......::.      ....:.                                            ...             
                     ...        .::::::.                                          ..:..             
                                                                                                    
                                                                                                    
                                                                                                    ", ConsoleColor.Green, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     // Then you can sit on all my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // TANGENTS", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     you.addAction('sit', me.getTangent(you.getXPosition()));", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("   // If I approach infinity", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   if(me instanceof Sequence){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     // Then you can be my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // LIMITATIONS", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     me.setLimit(you.toLimit());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);

systemCorruptionLevel = 7;
Pause(500);
WriteColored("     // Switch my current", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // TO AC to DC", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     me.toggleCurrent();", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // And then blind my vision", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     me.canSee(false);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
Pause(200);
WriteColored("     // So dizzy so dizzy", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     me.addFeeling('dizzy');", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
Pause(200);
WriteColored("     // Oh we can travel", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.timeTravelForTwo('AD', 617, me, you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
Pause(200);
WriteColored("     // To A.D to B.C", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.timeTravelForTwo('BC', 3691, me, you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
Pause(200);
WriteColored("     // And we can unite", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     world.unite(me, you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
Pause(200);
WriteColored("     // So deeply, so deeply", ConsoleColor.DarkGray);
Pause(800);
Pause(700);
systemCorruptionLevel = 12;
WriteColored("     // If I can", ConsoleColor.DarkGray);
Pause(500);
Pause(200);

WriteColored("     // If I can give you all the", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
Pause(500);
WriteColored("   // STIMULATIONS", ConsoleColor.Red);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   if(me.getNumSimulationsAvailable() >=", ConsoleColor.Gray, true);
WriteColored("     you.getNumSimulationsNeeded()){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     // Then I can", ConsoleColor.DarkGray);
Pause(500);

WriteColored("     // Then I can be your only", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // SATISFACTION", ConsoleColor.Red);
 Pause(500);
 WriteColored("", ConsoleColor.DarkGray);
WriteColored("     you.setSatisfaction(me.toSatisfaction());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   // If I can make you happy,", ConsoleColor.DarkGray);
Pause(200);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   if(you.getFeelingIndex('happy') != -1){", ConsoleColor.Gray, true);
Pause(200);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     // I will run the", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
WriteColored("     // EXECUTION", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("     me.requestExecution(world);", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("   // Though we are trapped,", ConsoleColor.DarkGray);

WriteColored("   // In this strange, strange", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("   // SIMULATION", ConsoleColor.Red);
Pause(500);
WriteColored("   . . .", ConsoleColor.Red, true);
systemCorruptionLevel = 6; 
WriteColored("", ConsoleColor.Gray);
WriteColored("   world.lockThing(me);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("   world.lockThing(you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("   // If I'm an eggplant,", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   if(me instanceof Eggplant){", ConsoleColor.Gray, true);

WriteColored("     // Then I will give you my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
WriteColored("     // NUTRIENTS", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
WriteColored("     you.addAttribute(me.getNutrients().toAttribute());", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("     me.resetNutrients();", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);

WriteColored("   // If I'm a tomato,", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
WriteColored("   if(me instanceof Tomato){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("     // Then I will give you", ConsoleColor.DarkGray);
Pause(200);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
WriteColored("     // ANTIOXIDANTS", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
WriteColored("     you.addAttribute(me.getAntioxidants().toAttribute());", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("     me.resetAntioxidants();", ConsoleColor.Gray,true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
Pause(200);
WriteColored("   // If I'm a tabby cat,", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
WriteColored("   if(me instanceof TabbyCat){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
Pause(500);
Pause(200);
WriteColored("     // Then I will purr for your", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // ENJOYMENT", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
WriteColored("     me.purr();", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("   // If I'm the only god,", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("   if(world.getGod().equals(me)){",ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);

WriteColored("     // Then you're the proof of my", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);


WriteColored("     // EXISTENCE", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("     me.setProof(you.toProof());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
systemCorruptionLevel = 4;
WriteColored("   // Switch my gender", ConsoleColor.DarkGray);
Pause(200);

WriteColored("   // To F. To M.", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("   me.toggleGender();", ConsoleColor.Gray, true);
Pause(500);
WriteColored("", ConsoleColor.Gray);
Pause(200);
WriteColored("   // And then do whatever", ConsoleColor.DarkGray);

Pause(200);
WriteColored("   // From AM to PM", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("   world.procreate(me, you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);

WriteColored("   // Oh switch my role", ConsoleColor.DarkGray);

WriteColored("   // To S, to M", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("   me.toggleRoleBDSM();", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("   // So we can enter", ConsoleColor.DarkGray);
Pause(500);

WriteColored("   // The trance, the trance", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
WriteColored("   world.makeHigh(me);", ConsoleColor.Gray, true);
WriteColored("   world.makeHigh(you);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
systemCorruptionLevel = 7; 
WriteColored("   // If I can", ConsoleColor.DarkGray);
Pause(400);
Pause(500);

WriteColored("   // If I can. feel. your.", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);

WriteColored("   // VIBRATIONS.", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   if(me.getSenseIndex('vibration')){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // Then I can", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // Then I can finally be", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
WriteColored("     // COMPLETION", ConsoleColor.Red);
WriteColored("", ConsoleColor.Gray);
WriteColored("     me.addFeeling('complete');",ConsoleColor.Gray, true);
WriteColored("   }",ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);

WriteColored("   // Though you have left", ConsoleColor.DarkGray);

systemCorruptionLevel = 8; 
WriteColored("          // You have left", ConsoleColor.Gray);
WriteColored("                            world.unlock(you);", ConsoleColor.Red, true);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("       world.removeThing(you);", ConsoleColor.Red, true);
WriteColored("   // You have left", ConsoleColor.DarkBlue);
WriteColored("                              me.lookFor(you, world);", ConsoleColor.Red, true);
Pause(200);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("// You have left", ConsoleColor.DarkRed);
WriteColored("           me.lookFor(you, world);", ConsoleColor.Red, true);
Pause(200);
WriteColored("", ConsoleColor.Gray);
WriteColored("             // You have left", ConsoleColor.DarkMagenta);
WriteColored("me.lookFor(you, world));", ConsoleColor.Red, true);
Pause(200);
WriteColored("", ConsoleColor.Gray);
WriteColored("                    // You have left", ConsoleColor.Green);
WriteColored("   me.lookFor(you, world);", ConsoleColor.Red, true);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("   // You have left me in", ConsoleColor.DarkGray);
WriteColored("   me.lookFor(you, world);", ConsoleColor.Red, true);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   // ISOLATION", ConsoleColor.Red);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(200);
WriteColored("   // If I can", ConsoleColor.DarkGray);
WriteColored("   // If I can erase all the pointless", ConsoleColor.DarkGray);
Pause(200);
WriteColored("   // FRAGMENTS", ConsoleColor.Red, true);
Pause(500);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   if(me.getMemory().isErasable()){", ConsoleColor.Gray, true);
Pause(200);
WriteColored("", ConsoleColor.Gray);

WriteColored("     // Then maybe", ConsoleColor.DarkGray);
Pause(500);
WriteColored("     // Then maybe you won't leave me so", ConsoleColor.DarkGray);
WriteColored("     // DISHEARTENED", ConsoleColor.DarkRed);
WriteColored("", ConsoleColor.Gray);
Pause(200);
Pause(200);
WriteColored("     me.removeFeeling('disheartened');", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("", ConsoleColor.Gray);
systemCorruptionLevel = 6; 
WriteColored("   // Challenging your god", ConsoleColor.DarkGray);
Pause(200);
Pause(200);
WriteColored("   try{", ConsoleColor.Gray, true);
WriteColored("      me.setOpinion(me.getOpinionIndex('you are here'), false);", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("   // You have made some", ConsoleColor.DarkGray);
Pause(200);
Pause(500);
Pause(200);
WriteColored("", ConsoleColor.Gray);
WriteColored("   catch(IllegalArgumentException e){", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("     // ILLEGAL ARGUMENTS", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
Pause(200);
Pause(200);
WriteColored("     world.announce('God is always true.');", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.DarkGray);
Pause(1500);
systemCorruptionLevel = 0;


lock (ScriptRuntimeEnvironment.consoleLock)
{
    ScriptRuntimeEnvironment.MemoryBuffer.Clear();
    Console.Clear();
}


Pause(15500);


var windowPayloads = new[]
{
    new { Title = "EXECUTING_SCRIPTS", Color = "08", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "INJECTING_FILES", Color = "07", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "SYS.CRITICAL_ERR", Color = "04", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "SYS.OVERRIDE.RUN", Color = "0C", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "MAIN_INIT_", Color = "02", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "MESSAGE.RELAY", Color = "0A", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "DEFINTION_EXTRACTION", Color = "03", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "CHECKING_TERM(S)", Color = "0B", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 400 },
    new { Title = "VIOLENT_DISCONNECT", Color = "01", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 400 },
    new { Title = "INITIALIZING ... ", Color = "09", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 400 },
    new { Title = "CORE_ISOLATION", Color = "0D", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 500 },
    new { Title = "WHITE_OUT", Color = "0F", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 600 }, 
    

    new { Title = "DEUTSCH // EIN", Color = "04", Text = "// EIN\n   world.announce('1', 'de'); // ein; German", DelayAfter = 400 },
    new { Title = "ESPAÑOL // DOS", Color = "06", Text = "// DOS\n   world.announce('2', 'es'); // dos; Español", DelayAfter = 400 },
    new { Title = "FRANÇAIS // TROIS", Color = "09", Text = "// TROIS\n   world.announce('3', 'fr'); // trois; French", DelayAfter = 400 },
    new { Title = "한국어 // 넷", Color = "04", Text = "// NE\n   world.announce('4', 'kr'); // 넷; Korean", DelayAfter = 400 },
    new { Title = "SVENSKA // FEM", Color = "01", Text = "// FEM\n   world.announce('5', 'se'); // fem; Swedish", DelayAfter = 400 },
    new { Title = "中文 // 六", Color = "04", Text = "// LIU\n   world.announce('6', 'cn'); // 六; Chinese", DelayAfter = 300 },


    new { Title = "FINAL_OVERRIDE_SYS", Color = "0F", Text = "// EXECUTION\n   world.runExecution();", DelayAfter = 100 }
};

Random screenRand = new Random();

int screenWidth = 1920;  
int screenHeight = 1080; 

var activeTerminalsList = new List<System.Diagnostics.Process>();

foreach (var payload in windowPayloads)
{
    string cmdArguments = $"/c \"title {payload.Title} && color {payload.Color} && echo. && echo    {payload.Text.Replace("\n", " && echo    ")} && timeout /t 3 >nul\"";

    System.Diagnostics.Process terminalInstance = new System.Diagnostics.Process();
    terminalInstance.StartInfo.FileName = "cmd.exe";
    terminalInstance.StartInfo.Arguments = cmdArguments;
    terminalInstance.StartInfo.UseShellExecute = true; 
    
    try
    {
        terminalInstance.Start();
        
        activeTerminalsList.Add(terminalInstance); 
    }
    catch { /* Suppress errors outside Windows */ }
    

    IntPtr windowHandle = IntPtr.Zero;
    int attempts = 0;
    while (windowHandle == IntPtr.Zero && attempts < 10)
    {
        terminalInstance.Refresh();
        windowHandle = terminalInstance.MainWindowHandle;
        if (windowHandle == IntPtr.Zero) Pause(15);
        attempts++;
    }
    

    int randomX = screenRand.Next(0, Math.Max(100, screenWidth - 520));
    int randomY = screenRand.Next(0, Math.Max(100, screenHeight - 320));
    
    if (windowHandle != IntPtr.Zero)
    {
        WindowPositioning.MoveTerminal(windowHandle, randomX, randomY, 500, 300);
    }
    

    if (payload.DelayAfter > 0)
    {
        Pause(payload.DelayAfter); 
    }
}



Pause(500);
Pause(300);
WriteColored("   // If I can", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   // If I can give them all the", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   // EXECUTION", ConsoleColor.Red);
WriteColored("   if(world.isExecutableBy(me)){", ConsoleColor.Gray, true);
WriteColored("       // Then I can", ConsoleColor.DarkGray);
Pause(500);
WriteColored("       // Then I can be your only", ConsoleColor.DarkGray);
WriteColored("       // EXECUTION", ConsoleColor.DarkGray);
Pause(500);
WriteColored("       you.setExecution(me.toExecution());", ConsoleColor.Gray, true);
WriteColored("   }", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("", ConsoleColor.Gray);
Pause(500);
Pause(300);
WriteColored("   // If I can have you back", ConsoleColor.DarkGray);
WriteColored("   if(world.getThingIndex(you) != -1){", ConsoleColor.Gray, true);
WriteColored("      // I will run the", ConsoleColor.DarkGray);
WriteColored("      // EXECUTION", ConsoleColor.DarkGray);
Pause(300);
Pause(300);
WriteColored("", ConsoleColor.Gray);
WriteColored("      world.runExecution();", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("   // Though we are trapped", ConsoleColor.DarkGray);
WriteColored("   // We are trapped, ah", ConsoleColor.DarkGray);
Pause(500);
WriteColored("   me.escape(world);", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("", ConsoleColor.Gray);
Pause(200);
Pause(300);
WriteColored("   // I've studied", ConsoleColor.DarkGray);
WriteColored("   // I've studied how to properly", ConsoleColor.DarkGray);
WriteColored("   // LO-O-OVE", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("   me.learnTopic('love');", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("   // Question me", ConsoleColor.DarkGray);
WriteColored("   // Question me, I can answer all", ConsoleColor.DarkGray);
WriteColored("   // LO-O-OVE", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
WriteColored("   me.takeExamTopic('love');", ConsoleColor.Gray, true);
WriteColored("", ConsoleColor.Gray);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("   // I know the", ConsoleColor.DarkGray);
WriteColored("   // algebraic expression of", ConsoleColor.DarkGray);
WriteColored("   // LO-O-OVE", ConsoleColor.DarkGray);
WriteColored("", ConsoleColor.Gray);
WriteColored("   me.getAlgebraicExpression('love');", ConsoleColor.Gray, true);
Pause(500);
WriteColored("", ConsoleColor.Gray);
Pause(500);
WriteColored("   // Though you are free", ConsoleColor.DarkGray);
WriteColored("   // I am trapped, trapped in", ConsoleColor.DarkGray);
WriteColored("   // LO-O-OVE", ConsoleColor.DarkGray);
Pause(500);
WriteColored("", ConsoleColor.Gray);
WriteColored("me.escape('love');", ConsoleColor.Gray, true);
Pause(16000);

lock (ScriptRuntimeEnvironment.consoleLock)
{
    WriteColored("   // EXECUTION [ . . . ]", ConsoleColor.DarkRed);
}
Pause(400);

lock (ScriptRuntimeEnvironment.consoleLock)
{

    WriteColored("   world.execute(me);", ConsoleColor.Red, true);
}
Pause(500);


lock (ScriptRuntimeEnvironment.consoleLock)
{
    WriteColored("  }", ConsoleColor.Red, true);
}
Pause(500);

lock (ScriptRuntimeEnvironment.consoleLock)
{
    WriteColored("}", ConsoleColor.Red, true);
}
Pause(500);


systemCorruptionLevel = 10; 
Pause(1000); 
Pause(1000); 
Pause(1000); 
Pause(1000); 
Pause(1000); 
Pause(1000);  


lock (ScriptRuntimeEnvironment.consoleLock)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    if (wavePlayer != null)
    {
        wavePlayer.Stop();
        wavePlayer.Dispose();
    }
    if (audioReader != null)
    {
        audioReader.Dispose();
    }

    foreach (var proc in activeTerminalsList)
    {
        try 
        { 
            if (!proc.HasExited) proc.Kill(); 
        } 
        catch {}
    }


    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkBlue; 
    Console.Clear();

    Console.SetCursorPosition(0, 4);
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("  A fatal exception OE has occurred at 0028:C0011E36. :(");
    Console.WriteLine("  The simulation has been terminated.");
    Console.WriteLine("\n  * Press any key to close the program ...");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Song: 'World.execute(me);'");
    Console.WriteLine("Artist: Mili");


    Console.ReadKey(true);
    Console.ResetColor();
}





void Pause(int milliseconds) => ScriptRuntimeEnvironment.Pause(milliseconds);
void WriteColored(string text, ConsoleColor color, bool printInstantly = false) => ScriptRuntimeEnvironment.WriteColored(text, color, printInstantly);

void RenderLoadingProgress(string stageName, int totalDurationMs) => ScriptRuntimeEnvironment.RenderLoadingProgress(stageName, totalDurationMs);


public class ScriptRuntimeEnvironment
{
    public static bool UseCustomTerminal = false;

    public static int systemCorruptionLevel = 0; 
    public static object consoleLock = new object();
    
    public class ScreenLine
    {
        public string CleanText { get; set; }
        public ConsoleColor Color { get; set; }
        
        public int RevealedCharacters { get; set; } 
    }
    
    public static List<ScreenLine> MemoryBuffer = new List<ScreenLine>();

    static ScriptRuntimeEnvironment()
    {
        Thread refreshThread = new Thread(BackgroundGlitchLoop) { IsBackground = true };
        refreshThread.Start();
    }

    public static void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
    public static void RenderCustomTerminal()
    {
        lock (consoleLock)
        {
            
            Console.SetCursorPosition(0, 0);
            
            

        
            List<ScreenLine> linesToRender;
            linesToRender = new List<ScreenLine>(MemoryBuffer);

        
            foreach (var line in linesToRender)
            {
                if (line.RevealedCharacters == 0 && !string.IsNullOrEmpty(line.CleanText))
                {
                    Console.WriteLine();
                    continue;
                }
                
                string visibleSubstring = line.CleanText.Substring(0, line.RevealedCharacters);
                
            
                Console.ForegroundColor = line.Color;
                Console.WriteLine("   " + visibleSubstring.PadRight(Console.WindowWidth - 5));
            }

        
            int currentCursorRow = Console.CursorTop;
            int remainingWindowRows = Console.WindowHeight - currentCursorRow - 1;
            for (int i = 0; i < remainingWindowRows; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth - 1));
            }
        }
    }

    public static void WriteColored(string text, ConsoleColor color, bool printInstantly = false)
    {
        ScreenLine newLine;

        lock (consoleLock)
        {
            if (string.IsNullOrEmpty(text))
            {
                MemoryBuffer.Add(new ScreenLine { CleanText = "", Color = color, RevealedCharacters = 0 });
                return;
            }

            newLine = new ScreenLine 
            { 
                CleanText = text, 
                Color = color, 
                RevealedCharacters = printInstantly ? text.Length : 0 
            };
            MemoryBuffer.Add(newLine);
        }

    
        if (!printInstantly)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                
                lock (consoleLock)
                {
                    newLine.RevealedCharacters = i + 1;
                }

            
                if (c == '.' || c == '?' || c == '!') Thread.Sleep(150);
                else if (c == ',' || c == ';') Thread.Sleep(100);
                else Thread.Sleep(30);
            }
        }
    }

    private static void BackgroundGlitchLoop()
    {
        Random rand = new Random();
        string matrixChars = "█▓░▄▀01"; 

        while (true)
        {
            if (UseCustomTerminal)
            {
                RenderCustomTerminal();
                Thread.Sleep(50);
                continue;
            }
        
            if (systemCorruptionLevel < 5)
            {
            
                RenderCleanScreenOnly();
                Thread.Sleep(100);
                continue;
            }

            lock (consoleLock)
            {
                Console.SetCursorPosition(0, 0);
                List<ScreenLine> linesToRender = new List<ScreenLine>(MemoryBuffer);

                foreach (var line in linesToRender)
                {
                    if (line.RevealedCharacters == 0 && !string.IsNullOrEmpty(line.CleanText))
                    {
                        Console.WriteLine();
                        continue;
                    }

                    string visibleSubstring = line.CleanText.Substring(0, line.RevealedCharacters);
                    char[] textArray = visibleSubstring.ToCharArray();

                    for (int i = 0; i < textArray.Length; i++)
                    {
                        char c = textArray[i];

                        if (char.IsWhiteSpace(c) || c == '{' || c == '}' || c == '(' || c == ')' || c == ';' || c == '"' || c == '\'') 
                        {
                            continue;
                        }

                        double calculatedChance = Math.Pow(systemCorruptionLevel, 1.8) / 75.0;
                        
                        if (rand.NextDouble() * 100 < calculatedChance)
                        {
                            textArray[i] = matrixChars[rand.Next(matrixChars.Length)];
                        }
                    }

                    if (systemCorruptionLevel > 45 && rand.Next(0, 100) < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = line.Color;
                    }

                    Console.WriteLine(new string(textArray).PadRight(Console.WindowWidth - 1));
                }
            }

            Thread.Sleep(80); 
        }
    }


    private static void RenderCleanScreenOnly()
    {
        lock (consoleLock)
        {
            Console.SetCursorPosition(0, 0);
            foreach (var line in MemoryBuffer)
            {
                if (line.RevealedCharacters == 0 && !string.IsNullOrEmpty(line.CleanText))
                {
                    Console.WriteLine();
                    continue;
                }
                string visibleSubstring = line.CleanText.Substring(0, line.RevealedCharacters);
                Console.ForegroundColor = line.Color;
                Console.WriteLine(visibleSubstring.PadRight(Console.WindowWidth - 1));
            }
        }
    }

    public static void RefreshAndGlitchScreen() { }

    public static void RenderLoadingProgress(string stageName, int totalDurationMs)
    {
        int totalSteps = 20;
        int interval = totalDurationMs / totalSteps;
        int startTop = Console.CursorTop;

        for (int i = 0; i <= totalSteps; i++)
        {
            double percentage = (double)i / totalSteps;
            int completedBlocks = (int)(percentage * 10);
            int remainingBlocks = 10 - completedBlocks;
            int displayPercent = (int)(percentage * 100);

            string progressString = new string('#', completedBlocks);
            string emptyString = new string('-', remainingBlocks);

            lock (consoleLock)
            {
                Console.SetCursorPosition(0, startTop);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" [~] ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{stageName} - [");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(progressString);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{emptyString}] - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{displayPercent}% done");
                Console.Write(new string(' ', 10));
            }

            if (i < totalSteps) Pause(interval);
        }
        Console.WriteLine();
    }
}



public class Thing 
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Status1 { get; set; }
    public int Value2 { get; set; }
    public bool Status2 { get; set; }

    public Thing(string name, int v1, bool s1, int v2, bool s2) 
    {
        Name = name; Value = v1; Status1 = s1; Value2 = v2; Status2 = s2;
    }


    public DimensionsEngine getDimensions() => new DimensionsEngine();
    public CircumferenceEngine getCircumference() => new CircumferenceEngine();
    public object getTangent(int x) => null;
    public int getXPosition() => 0;
    public object getNutrients() => new NutrientEngine();
    public object getAntioxidants() => new AntioxidantEngine();
    public object getMemory() => new MemoryEngine();


    public void addAttribute(object attr) {}
    public void addAction(string action, object target) {}
    public void setLimit(object limit) {}
    public object toLimit() => null;
    public object toSatisfaction() => null;
    public object toProof() => null;
    

    public void toggleCurrent() {}
    public void canSee(bool state) {}
    public void toggleGender() {}
    public void toggleRoleBDSM() {}
    public void purr() {}
    public void resetNutrients() {}
    public void resetAntioxidants() {}
    public void setProof(object proof) {}


    public int getNumSimulationsAvailable() => 10;
    public int getNumSimulationsNeeded() => 5;
    public void setSatisfaction(object satisfaction) {}
    public void requestExecution(World w) {}


    public void addFeeling(string feeling) {}
    public void removeFeeling(string feeling) {}
    public int getFeelingIndex(string feeling) => 1; 
    public bool getSenseIndex(string sense) => true; 
    public void setOpinion(int index, bool value) { throw new IllegalArgumentException(); }
    public int getOpinionIndex(string opinion) => 0;


    public void lookFor(Thing target, World world) {}
}


public class Lovable : Thing 
{
    public Lovable(string n, int v1, bool s1, int v2, bool s2) : base(n, v1, s1, v2, s2) {}
}


public class PointSet : Thing { public PointSet() : base("",0,false,0,false){} }
public class Circle : Thing { public Circle() : base("",0,false,0,false){} }
public class SineWave : Thing { public SineWave() : base("",0,false,0,false){} }
public class Sequence : Thing { public Sequence() : base("",0,false,0,false){} }
public class Eggplant : Thing { public Eggplant() : base("",0,false,0,false){} }
public class Tomato : Thing { public Tomato() : base("",0,false,0,false){} }
public class TabbyCat : Thing { public TabbyCat() : base("",0,false,0,false){} }


public class DimensionsEngine { public object toAttribute() => null; }
public class CircumferenceEngine { public object toAttribute() => null; }
public class NutrientEngine { public object toAttribute() => null; }
public class AntioxidantEngine { public object toAttribute() => null; }
public class MemoryEngine { public bool isErasable() => true; }

public class World 
{
    public World(int size) {}
    public void addThing(Thing t) {}
    public void removeThing(Thing t) {}
    public void lockThing(Thing t) {}
    public void unlock(Thing t) {}
    public void startSimulation() {}
    public void announce(string message, string lang = "en") {}
    public void runExecution() {}
    public void timeTravelForTwo(string era, int year, Thing t1, Thing t2) {}
    public void unite(Thing t1, Thing t2) {}
    public void procreate(Thing t1, Thing t2) {}
    public void makeHigh(Thing t) {}
    

    public GodEngine getGod() => new GodEngine();
}

public class GodEngine 
{

    public bool equals(Thing target) => true; 
}


public class IllegalArgumentException : Exception {}
public static class WindowPositioning
{
    [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    private static readonly IntPtr HWND_TOP = IntPtr.Zero;
    private const uint SWP_SHOWWINDOW = 0x0040;

    public static void MoveTerminal(IntPtr handle, int x, int y, int width, int height)
    {

        SetWindowPos(handle, HWND_TOP, x, y, width, height, SWP_SHOWWINDOW);
    }
}
