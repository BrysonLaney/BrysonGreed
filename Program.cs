using Raylib_cs;
namespace Greed
{
    static class Program
    {
        public static void Main()
        {//new classes to be used as needed
            movement player = new movement();
            collision checkplayer = new collision();
            Random rndm = new Random();
            rockspawn rocky = new rockspawn();
            rocks rock = new rocks();
            gems gem = new gems();
            gemspawn shiny = new gemspawn();
            score playerpoints = new score();
            List<rocks> rocklist = new List<rocks>();
            List<gems> gemlist = new List<gems>();
            //initialization of window and fps
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(1200, 720, "");
            int counter = 0;
            //loop for while the window is open so the program will have frames
            while (!Raylib.WindowShouldClose()){
                counter += 1;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                //updates each gem every loop
                for(int i = 0; i < gemlist.Count(); i++){
                    gemlist[i].gemupdate(gemlist[i], counter);   
                }//updates each rock ever loop
                for(int i = 0; i < rocklist.Count(); i++){
                    rocklist[i].rockupdate(rocklist[i], counter);
                }
                //checks for collison between the player and the rocks or gems
                checkplayer.check(player.playerx(), player.playery(), gemlist, rocklist, playerpoints);
                Raylib.DrawText("Score: " + playerpoints.getscore().ToString(), 25, 25, 25, Color.GREEN);
                Raylib.DrawText("#", player.playerx(), player.playery(), 20, Color.PURPLE);
                Raylib.DrawText(counter.ToString(), 200, 200, 20,Color.DARKGREEN);
                Raylib.DrawText(player.getx().ToString(), 100, 100, 20,Color.DARKGREEN);
                //checks for movements and input 
                if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)){
                    player.moveright();
                    if(player.playerx() > 1190){
                        player.moveleft();
                    }
                }
                if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)){
                    player.moveleft();
                    if(player.playerx() < 0){
                        player.moveright();
                    }
                }
                //spawns a gem or a rock every 15 frames
                if(counter % 15 == 0){
                    int x = 0;
                    //used to decide if it will spawn a rock or gem
                    x = rndm.Next(1, 3);
                    //spawns a gem in x == 2
                    if(x == 2){
                        gems newgem = new gems();
                        newgem.startup();
                        gemlist.Add(newgem);
                    }
                    //spawns a rock if x == 1
                    if(x == 1){
                        rocks newrock = new rocks();
                        newrock.startup();
                        rocklist.Add(newrock);
                    }
                    
                }
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}