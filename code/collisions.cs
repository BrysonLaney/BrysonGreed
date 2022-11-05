class collision{
    public void check(int playerx, int playery, List<gems> gemlist, List<rocks> rocklist, score points){
        //for loop to check each of the rocks
        for(int i = 0; i < gemlist.Count(); i++){
            //used to check the full size of the gem
            for(int a = 0; a < 30; a++){
                //checks for overlapping between the player anf the gem
                if(playerx + 10 == gemlist[i].gemspotx() + a && playery == gemlist[i].gemspoty() + a){
                    gemlist.RemoveAt(i);
                    points.addscoregems();
                }
            }
        } 
        //for loop to check each of the rocks
        for(int i = 0; i < rocklist.Count(); i++){
            //checks the full size of the rock
            for(int a = 0; a < 30; a++){
                //checks for overlapping between the rock and the player
                if(playerx + 10 == rocklist[i].rockspotx() + a && playery == rocklist[i].rockspoty() + a){
                    rocklist.RemoveAt(i);
                    points.addscorerocks();
                }
            }
        }
    }
}