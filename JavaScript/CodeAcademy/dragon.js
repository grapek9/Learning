var slaying = true;
var youHit = Math.floor(Math.random()*2);
var damageThisRound = Math.floor(Math.random()*5+1);
var totalDamage = 0; 
while(slaying){
    if(youHit === 1){
        console.log("HAHA you hited that bloody dragon");
        totalDamage += damageThisRound;
        if(totalDamage >= 4){
            console.log("You have slayed this bloody dragon");
        }else{
            console.log("You have got killed :<");
        }
        
    }
    else{
        console.log("You missed that god damn dragon!");
    }
    console.log(totalDamage);
    slaying = false;


}