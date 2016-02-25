
window.addEventListener("load", function load() {
    console.log("Loaded");
    window.addEventListener('devicemotion', onDeviceMotion, false);

});


// TODO: update every few seconds
function onDeviceMotion(e)
{
    //run this function every 5 seconds
    
    getAccelReadings(e);
}

function getAccelReadings(e)
{
    var x = e.acceleration.x;
    var y = e.acceleration.y;
    var z = e.acceleration.z;

   
   document.getElementById('x').innerText = (x*100);
   document.getElementById('y').innerText = (y*100);
   document.getElementById('z').innerText = (z*100);
}
