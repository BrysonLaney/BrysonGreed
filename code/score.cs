using Raylib_cs;
public class score : points{//score class for display on screen
    public int points;
    new points scoreboard = new points();
    //returns the score
    public int getscore(){
        return points;
    }//adds score for the gems
    public void addscoregems(){
        points += scoreboard.getgempoint();
    }//removes score for the rocks
    public void addscorerocks(){
        points -= scoreboard.getrockpoint();
    }
}
public class points : gems{//ctreates the points for the points score class to use
//leaving a comment here to return to this code later and add optional color multipliers
    new Random rndm = new Random();
    new gems shiny = new gems();
    new rocks petrocks = new rocks();
    //cretaes a value of 50 points for the rocks
    public int getrockpoint(){
        return  50;
    }
    //creates 125 points for the gem
    public int getgempoint(){
        return 125;
    }
}
public class gems : rocks{
    //gems creates almost the same thing as rocks, but hsa a different collor pallete
    static Color orange;
    static Color lime;
    static Color darkblue;
    static Color maroon;
    new rocks petrock = new rocks();
    private Color gemcolor;
    new Random rndm = new Random();
    private int gemx;
    private int gemy;
    private char gemtext;
    gemspawn newgem = new gemspawn();
    private List<Color> colorlist = new List<Color>();
    public void startup(){
        //initializes the gems class and adds the colors to the list
        gemtext = '*';
        gemy = 10;
        colorlist.Add(orange);
        colorlist.Add(maroon);
        colorlist.Add(lime);
        colorlist.Add(darkblue);
        gemcolor = colorlist[rndm.Next(0, 3)];
        gemx = newgem.spawngem();
    }
    //updates the gems that are on the screen
    public void gemupdate(gems gemlist, int counter){
        gemy += 1;
        Raylib.DrawText(gemtext.ToString(), gemlist.gemx, gemlist.gemy, 30, Color.PINK);
    }
    //returns the x coords for the gem
    public int gemspotx(){
        return gemx;
    }
    //returns the y coords for the gem
    public int gemspoty(){
        return gemy;
    }
}
public class rocks{
    //rocks class creates all of the necessary information for the rocks class including x and y cords
    static Color blue;
    static Color red;
    static Color green;
    static Color yellow;
    private List<Color> colorlist = new List<Color>();
    new Random rndm = new Random();
    private Color rockcolor;
    private int rockx;
    private int rocky;
    rockspawn newrock = new rockspawn();
    private char rocktext;
    //updtaes the rocks on the screen
    public void rockupdate(rocks rocklist, int counter){
        rocky += 1; 
        Raylib.DrawText(rocktext.ToString(), rocklist.rockx, rocklist.rocky, 30, Color.BROWN);
    }
    //returns the rocks x coorsd
    public int rockspotx(){
        return rockx;
    }
    //returns the rocks y coords
    public int rockspoty(){
        return rocky;
    }
    //initializes the rocks
    public void startup(){
        rocktext = 'o';
        rocky = 10;
        colorlist.Add(blue);
        colorlist.Add(red);
        colorlist.Add(green);
        colorlist.Add(yellow);
        rockx = newrock.spawnrock();
        rockcolor = colorlist[rndm.Next(0, 3)];
    }
}