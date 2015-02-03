#pragma strict

var pointB : Transform;
var speed : float;
function Start () 
{
 var pointA = transform.position; 
 while (true)
  { 
    yield MoveObject(transform, pointA, pointB.position, 3.0); 
    yield MoveObject(transform, pointB.position, pointA, 3.0);
   } 
 }

function MoveObject (thisTransform : Transform, startPos : Vector3, endPos : Vector3, time : float) 
{
    var i = 0.0; 
    var rate = speed/time; 
     while (i < 1.0) 
       { 
         i += Time.deltaTime * rate;
         thisTransform.position = Vector3.Lerp(startPos, endPos, i); yield;
       }
}