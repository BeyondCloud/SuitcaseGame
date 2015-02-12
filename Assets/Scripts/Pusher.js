#pragma strict

var target : GameObject; //destination
var liftSpeed : float = 50;//speed (it will complete the motion in 1/speed seconds)

public var Key : String;
private var moving : boolean = false; //flag 
private var movingBack : boolean = false; //back flag 
//private var canPress : boolean = true;
private var timer :float;
private var weight : float = 0; //amount moved 
private var startPosition : Vector3; //Where we start;
function Update() 
{ 
    timer += Time.deltaTime;
  if(target)
    { 
    
     if(Input.GetKeyDown(Key) )
       {    //just pressed Jump 
       print("w down");
         if(timer  > 0.3f)
         {
         
          timer = 0;
          startPosition = transform.position; //Set the start 
          moving = true; //set flag 
         }
       } 
     if(transform.position == target.transform.position)
       {
        moving = false; //reset flag 
        movingBack = true;
       }
      if(transform.position == startPosition)
      {
         movingBack = false;

      }
     if(moving) //check flag 
       {
        weight += Time.deltaTime * liftSpeed; //amount 
        transform.position = Vector3.Lerp(startPosition, target.transform.position, weight);
       } 
       if(movingBack) //check flag 
       {
        weight -= Time.deltaTime * liftSpeed; //amount 
        transform.position = Vector3.Lerp(startPosition, target.transform.position , weight);
       } 
       
    } 
}
function OnMouseDown()
{
         
         audio.Play();
         print("mouse down");
            if(timer  > 0.3f)
         {
          timer = 0;
          startPosition = transform.position; //Set the start 
          moving = true; //set flag 
         }

}

