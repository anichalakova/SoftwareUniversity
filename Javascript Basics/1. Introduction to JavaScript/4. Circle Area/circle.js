function findArea () {
	var x = 7;
	var xArea = 3.14 * (x * x);
	document.getElementById("7-area").innerHTML = "area = " + xArea;

	var y = 1.5;
	var yArea = 3.14 * (y * y);
	document.getElementById("1.5-area").innerHTML = "area = " + yArea;

	var z = 20;
	var zArea = 3.14 * (z * z);
	document.getElementById("20-area").innerHTML = "area = " + zArea;
}

findArea();