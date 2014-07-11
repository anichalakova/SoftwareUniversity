function getCurrentTime() {
	var currentdate = new Date();
	var datetime = "Time is: " + currentdate.getHours() + ":" 
								+ currentdate.getMinutes() + ":" 
								+ currentdate.getSeconds();

	console.log(datetime);

	document.getElementById("hours").innerHTML = currentdate.getHours() + " ";
	document.getElementById("minutes").innerHTML = currentdate.getMinutes() + " ";
	document.getElementById("seconds").innerHTML = currentdate.getSeconds() + " ";

}

getCurrentTime();