  function calc()
  {
	var e = document.getElementById("conType");
	var conType = e.options[e.selectedIndex].value;
	e = document.getElementById("conType1");
	var conType1 = e.options[e.selectedIndex].value;
	e = document.getElementById("conType2");
	var conType2 = e.options[e.selectedIndex].value;
	
	var m = 1;
	//#region Lots of If Statements

	if (conType == "Distance")
	{
		if (conType1 == "Meters")
		{
			if (conType2 == "Microns")
			{
				m = 1000000;
			}
			if (conType2 == "Millimeters")
			{
				m = 1000;
			}
			if (conType2 == "Kilometers")
			{
				m = .001;
			}
			if (conType2 == "Inches")
			{
				m = 39.3701;
			}
			if (conType2 == "Feet")
			{
				m = 3.28084;
			}
			if (conType2 == "Miles")
			{
				m = 0.000621371;
			}
		}
		if (conType1 == "Microns")
		{
			if (conType2 == "Meters")
			{
				m = .00001;
			}
			if (conType2 == "Millimeters")
			{
				m = .001;
			}
			if (conType2 == "Kilometers")
			{
				m = .00000005;
			}
			if (conType2 == "Inches")
			{
				m = 0.000393701;
			}
			if (conType2 == "Feet")
			{
				m = 0.0000328084;
			}
			if (conType2 == "Miles")
			{
				m = .0000000062137;
			}
		}
		if (conType1 == "Millimeters")
		{
			if (conType2 == "Meters")
			{
				m = .001;
			}
			if (conType2 == "Microns")
			{
				m = 1000;
			}
			if (conType2 == "Kilometers")
			{
				m = .000001;
			}
			if (conType2 == "Inches")
			{
				m = 0.0393701;
			}
			if (conType2 == "Feet")
			{
				m = 0.00328084;
			}
			if (conType2 == "Miles")
			{
				m = .00000062137;
			}
		}
		if (conType1 == "Kilometers")
		{
			if (conType2 == "Meters")
			{
				m = 1000;
			}
			if (conType2 == "Microns")
			{
				m = 1000000000;
			}
			if (conType2 == "Millimeters")
			{
				m = 1000000;
			}
			if (conType2 == "Inches")
			{
				m = 39370.1;
			}
			if (conType2 == "Feet")
			{
				m = 3280.84;
			}
			if (conType2 == "Miles")
			{
				m = 0.621371;
			}
		}
		if (conType1 == "Inches")
		{
			if (conType2 == "Meters")
			{
				m = 0.0254;
			}
			if (conType2 == "Micron")
			{
				m = 25400;
			}
			if (conType2 == "Millimeters")
			{
				m = 25.4;
			}
			if (conType2 == "Kilometers")
			{
				m = .0000254;
			}
			if (conType2 == "Feet")
			{
				m = 0.0833333;
			}
			if (conType2 == "Miles")
			{
				m = .000015783;
			}
		}
		if (conType1 == "Feet")
		{
			if (conType2 == "Meters")
			{
				m = 0.3048;
			}
			if (conType2 == "Microns")
			{
				m = 304800;
			}
			if (conType2 == "Millimeters")
			{
				m = 304.8;
			}
			if (conType2 == "Kilometers")
			{
				m = 0.0003048;
			}
			if (conType2 == "Inches")
			{
				m = 12;
			}
			if (conType2 == "Miles")
			{
				m = 0.000189394;
			}
		}
		if (conType1 == "Miles")
		{
			if (conType2 == "Meters")
			{
				m = 1609.34;
			}
			if (conType2 == "Microns")
			{
				m = 1609340000;
			}
			if (conType2 == "Millimeters")
			{
				m = 1609340;
			}
			if (conType2 == "Kilometers")
			{
				m = 1.60934;
			}
			if (conType2 == "Inches")
			{
				m = 63360;
			}
			if (conType2 == "Feet")
			{
				m = 5280;
			}
		}
	}
	if (conType == "Force")
	{
		if (conType1 == "Pounds" && conType2 == "Newtons")
		{
			m = 4.448221628254617;
		}
		if (conType1 == "Newtons" && conType2 == "Pounds")
		{
			m = 0.224808942443;
		}
	}
	if (conType == "Torque")
	{
		if (conType1 == "N-m")
		{
			if (conType2 == "in-lb")
			{
				m = 39.37 / 4.4;
			}
			if (conType2 == "in-oz")
			{
				m = 629.92 / 4.4;
			}
			if (conType2 == "N-cm")
			{
				m = 100;
			}
		}
		if (conType1 == "in-lb")
		{
			if (conType2 == "N-m")
			{
				m = 4.4 / 39.37;
			}
			if (conType2 == "in-oz")
			{
				m = 16;
			}
			if (conType2 == "N-cm")
			{
				m = 440 / 39.37;
			}
		}
		if (conType1 == "in-oz")
		{
			if (conType2 == "N-m")
			{
				m = 4.4 / 629.92;
			}
			if (conType2 == "in-lb")
			{
				m = .0625;
			}
			if (conType2 == "N-cm")
			{
				m = 440 / 629.92;
			}
		}
		if (conType1 == "N-cm")
		{
			if (conType2 == "N-m")
			{
				m = .001;
			}
			if (conType2 == "in-lb")
			{
				m = 39.37 / 440;
			}
			if (conType2 == "in-oz")
			{
				m = 629.92 / 440;
			}
		}
	}
	if (conType == "Rotational Inertia")
	{
		if (conType1 == "kg-m^2")
		{
			if (conType2 == "kg-cm^2")
			{
				m = 10000;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 1000000;
			}
			if (conType2 == "g-cm^2")
			{
				m = 10000000;
			}
			if (conType2 == "g-mm^2")
			{
				m = 1000000000;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.1019716213;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 10.19716213;
			}
			if (conType2 == "oz-in^2")
			{
				m = 54674.74983;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 141.6119312;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 23.730360404;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.737562142;
			}
			if (conType2 == "lb-in^2")
			{
				m = 3417.171898209;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 8.850745703;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.737562142;
			}
		}
		if (conType1 == "kg-cm^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = .0001;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 100;
			}
			if (conType2 == "g-cm^2")
			{
				m = 1000;
			}
			if (conType2 == "g-mm^2")
			{
				m = 100000;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000010197;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.001019716;
			}
			if (conType2 == "oz-in^2")
			{
				m = 5.467474983;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.014161193;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.002373036;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.000073756;
			}
			if (conType2 == "lb-in^2")
			{
				m = 0.34171719;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.000885075;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.000073756;
			}
		}
		if (conType1 == "kg-mm^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.000001;
			}
			if (conType2 == "kg-cm^2")
			{
				m = .01;
			}
			if (conType2 == "g-cm^2")
			{
				m = 10;
			}
			if (conType2 == "g-mm^2")
			{
				m = 1000;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000000102;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.000010197;
			}
			if (conType2 == "oz-in^2")
			{
				m = 0.05467475;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.000141612;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.00002373;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.000000738;
			}
			if (conType2 == "lb-in^2")
			{
				m = 0.003417172;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.000008851;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.000000738;
			}
		}
		if (conType1 == "g-cm^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.0000001;
			}
			if (conType2 == "kg-cm^2")
			{
				m = .001;
			}
			if (conType2 == "kg-mm^2")
			{
				m = .1;
			}
			if (conType2 == "g-mm^2")
			{
				m = 100;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.0000000102;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.0000010197;
			}
			if (conType2 == "oz-in^2")
			{
				m = 0.005467475;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.0000141612;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.000002373;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.0000000738;
			}
			if (conType2 == "lb-in^2")
			{
				m = 0.0003417172;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.0000008851;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.0000000738;
			}
		}
		if (conType1 == "g-mm^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.000000001;
			}
			if (conType2 == "kg-cm^2")
			{
				m = .00001;
			}
			if (conType2 == "kg-mm^2")
			{
				m = .001;
			}
			if (conType2 == "g-cm^2")
			{
				m = .01;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000000000102;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.000000010197;
			}
			if (conType2 == "oz-in^2")
			{
				m = 0.00005467475;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.000000141612;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.00000002373;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.000000000738;
			}
			if (conType2 == "lb-in^2")
			{
				m = 0.000003417172;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.000000008851;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.000000000738;
			}
		}
		if (conType1 == "kg-m-s^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 9.80665;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 98066.499997877;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 9806649.9997877;
			}
			if (conType2 == "g-cm^2")
			{
				m = 98066499.997877;
			}
			if (conType2 == "g-mm^2")
			{
				m = 9806649999.7877;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 100;
			}
			if (conType2 == "oz-in^2")
			{
				m = 536176.13540876;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 1388.738645072;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 232.715338853;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 7.233013779;
			}
			if (conType2 == "lb-in^2")
			{
				m = 33511.00879485;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 86.796165346;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 7.233013779;
			}
		}
		if (conType1 == "kg-cm-s^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.0980665;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 980.66499997877;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 98066.499997877;
			}
			if (conType2 == "g-cm^2")
			{
				m = 980664.99997877;
			}
			if (conType2 == "g-mm^2")
			{
				m = 98066499.997877;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = .01;
			}
			if (conType2 == "oz-in^2")
			{
				m = 5361.7613540876;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 13.88738645072;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 2.32715338853;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = .07233013779;
			}
			if (conType2 == "lb-in^2")
			{
				m = 335.1100879485;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = .86796165346;
			}
			if (conType2 == "slug-ft^2")
			{
				m = .07233013779;
			}
		}
		if (conType1 == "oz-in^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.00001829;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 0.182899785;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 18.28997852;
			}
			if (conType2 == "g-cm^2")
			{
				m = 182.899785204;
			}
			if (conType2 == "g-mm^2")
			{
				m = 18289.978520419;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000001865;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.000186506;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.002590079;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.000434028;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.00001349;
			}
			if (conType2 == "lb-in^2")
			{
				m = 0.062500001;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.00016188;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.00001349;
			}
		}
		if (conType1 == "oz-in-s^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.007061552;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 70.615518871;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 7061.551887091;
			}
			if (conType2 == "g-cm^2")
			{
				m = 70615.518870913;
			}
			if (conType2 == "g-mm^2")
			{
				m = 7061551.8870913;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000720078;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.072007789;
			}
			if (conType2 == "oz-in^2")
			{
				m = 386.088582838;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.167573171;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.005208333;
			}
			if (conType2 == "lb-in^2")
			{
				m = 24.130536666;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.0625;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.005208333;
			}
		}
		if (conType1 == "lb-ft^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.04214011;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 421.401100938;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 42140.110093805;
			}
			if (conType2 == "g-cm^2")
			{
				m = 421401.10093805;
			}
			if (conType2 == "g-mm^2")
			{
				m = 42140110.093805;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.004297095;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.429709535;
			}
			if (conType2 == "oz-in^2")
			{
				m = 2303.999977187;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 5.967542371;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.03108095;
			}
			if (conType2 == "lb-in^2")
			{
				m = 144;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.372971398;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.03108095;
			}
		}
		if (conType1 == "lb-ft-s^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 1.355817962;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 13558.179618926;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 1355817.9618926;
			}
			if (conType2 == "g-cm^2")
			{
				m = 13558179.618926;
			}
			if (conType2 == "g-mm^2")
			{
				m = 1355817961.8926;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.138254956;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 13.825495576;
			}
			if (conType2 == "oz-in^2")
			{
				m = 74129.007881498;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 191.999999939;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 32.174048878;
			}
			if (conType2 == "lb-in^2")
			{
				m = 4633.063038467;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 12;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 1;
			}
		}
		if (conType1 == "lb-in^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.00029264;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 2.926396534;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 292.639653429;
			}
			if (conType2 == "g-cm^2")
			{
				m = 2926.396534292;
			}
			if (conType2 == "g-mm^2")
			{
				m = 292639.6534292;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.000029841;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 0.002984094;
			}
			if (conType2 == "oz-in^2")
			{
				m = 15.999999842;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 0.041441266;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 0.006944444;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.00021584;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 0.002590079;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.00021584;
			}
		}
		if (conType1 == "lb-in-s^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 0.11298483;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 1129.848301552;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 112984.83015516;
			}
			if (conType2 == "g-cm^2")
			{
				m = 1129848.3015516;
			}
			if (conType2 == "g-mm^2")
			{
				m = 112984830.15516;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.011521246;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 1.152124631;
			}
			if (conType2 == "oz-in^2")
			{
				m = 6177.417323319;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 15.999999995;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 2.68117074;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 0.083333333;
			}
			if (conType2 == "lb-in^2")
			{
				m = 386.08858653;
			}
			if (conType2 == "slug-ft^2")
			{
				m = 0.083333333;
			}
		}
		if (conType1 == "slug-ft^2")
		{
			if (conType2 == "kg-m^2")
			{
				m = 1.355817962;
			}
			if (conType2 == "kg-cm^2")
			{
				m = 13558.179618926;
			}
			if (conType2 == "kg-mm^2")
			{
				m = 1355817.9618926;
			}
			if (conType2 == "g-cm^2")
			{
				m = 13558179.618926;
			}
			if (conType2 == "g-mm^2")
			{
				m = 1355817961.8926;
			}
			if (conType2 == "kg-m-s^2")
			{
				m = 0.138254956;
			}
			if (conType2 == "kg-cm-s^2")
			{
				m = 13.825495576;
			}
			if (conType2 == "oz-in^2")
			{
				m = 74129.007881498;
			}
			if (conType2 == "oz-in-s^2")
			{
				m = 191.999999939;
			}
			if (conType2 == "lb-ft^2")
			{
				m = 32.174048878;
			}
			if (conType2 == "lb-ft-s^2")
			{
				m = 1;
			}
			if (conType2 == "lb-in^2")
			{
				m = 4633.063038467;
			}
			if (conType2 == "lb-in-s^2")
			{
				m = 12;
			}
		}
	}
	if (conType == "Mass")
	{
		if (conType1 == "Pound")
		{
			if (conType2 == "Ounce")
			{
				m = 16;
			}
			if (conType2 == "Short Ton")
			{
				m = 0.0005;
			}
			if (conType2 == "Kilogram")
			{
				m = 0.453592;
			}
			if (conType2 == "Gram")
			{
				m = 453.592;
			}
		}
		if (conType1 == "Ounce")
		{
			if (conType2 == "Pound")
			{
				m = 1/16;
			}
			if (conType2 == "Short Ton")
			{
				m = 0.0005/16;
			}
			if (conType2 == "Kilogram")
			{
				m = 0.453592/16;
			}
			if (conType2 == "Gram")
			{
				m = 453.592/16;
			}
		}
		if (conType1 == "Short Ton")
		{
			if (conType2 == "Pound")
			{
				m = 1/0.0005;
			}
			if (conType2 == "Ounce")
			{
				m = 14.58333/0.0005;
			}
			if (conType2 == "Kilogram")
			{
				m = 0.453592/0.0005;
			}
			if (conType2 == "Gram")
			{
				m = 453.592/0.0005;
			}
		}
		if (conType1 == "Kilogram")
		{
			if (conType2 == "Pound")
			{
				m = 1/0.453592;
			}
			if (conType2 == "Ounce")
			{
				m = 14.58333/0.453592;
			}
			if (conType2 == "Short Ton")
			{
				m = 0.0005/0.453592;
			}
			if (conType2 == "Gram")
			{
				m = 453.592/0.453592;
			}
		}
		if (conType1 == "Gram")
		{
			if (conType2 == "Pound")
			{
				m = 1/453.592;
			}
			if (conType2 == "Ounce")
			{
				m = 14.58333/453.592;
			}
			if (conType2 == "Short Ton")
			{
				m = 0.0005/453.592;
			}
			if (conType2 == "Kilogram")
			{
				m = 0.453592/453.592;
			}
		}
	}
	if (conType == "Acceleration")
	{
		if (conType1 == "g")
		{
			if (conType2 == "m/s^2")
			{
				m = 9.806649999788;
			}
			if (conType2 == "in/s^2")
			{
				m = 386.0885826673;
			}
		}
		if (conType1 == "m/s^2")
		{
			if (conType2 == "g")
			{
				m = 0.1019713213;
			}
			if (conType2 == "in/s^2")
			{
				m = 39.37007874;
			}
		}
		if (conType1 == "in/s^2")
		{
			if (conType2 == "g")
			{
				m = 0.00259007918103;
			}
			if (conType2 == "m/s^2")
			{
				m = 0.0254000000001;
			}
		}
	}
	//#endregion
	
	var a = parseFloat(document.getElementById("a").value);
	var b = parseFloat(document.getElementById("b").value);
	var val = 0;
	if(document.activeElement == document.getElementById("a") || document.activeElement == document.getElementById("conType2"))
	{
		val = a*m;
		document.getElementById("b").value = val;
	}
	else
	{
		val = b/m;
		document.getElementById("a").value = val;
	}
  }
  function clear(elmId)
  {
    var sel= document.getElementById(elmId);
    for (i = sel.options.length-1; i >=0 ; i--) {
	  sel.remove(i);
	}
  }
  function generateOptions(elmId)
  {
    var options;
    var i = 0;
    var sel= document.getElementById(elmId);
	var e = document.getElementById('conType');
	
    switch(e.options[e.selectedIndex].value){
	  case "Distance":
	    options = ["Meters", "Microns", "Millimeters", "Kilometers", "Inches", "Feet", "Miles"];
		break;
      case "Force":
	    options = ["Pounds", "Newtons"];
	    break;
	  case "Torque":
		options = ["N-m", "in-lb", "in-oz", "N-cm"];
	    break;
	  case "Rotational Inertia":
		options = ["kg-m^2", "kg-cm^2", "kg-mm^2", "g-cm^2", "g-mm^2", "kg-m-s^2", "kg-cm-s^2", "oz-in^2", "oz-in-s^2", "lb-ft^2", "lb-ft-s^2", "lb-in^2", "lb-in-s^2", "slug-ft^2"];
	    break;
	  case "Mass":
	    options = ["Pound", "Ounce", "Short Ton", "Kilogram", "Gram"];
	    break;
	  case "Acceleration":
	    options = ["g", "m/s^2", "in/s^2"];
		break;
	}
    for (i = 0; i < options.length; i++) {
      var newopt = document.createElement('option');
      var optIdName = 'opt' + i;
      newopt.setAttribute('id',optIdName);
      newopt.innerHTML = options[i];
      sel.appendChild(newopt);
    }
  }
  function generateAllOptions()
  {
    clear("conType1");
	generateOptions("conType1");
	clear("conType2");
	generateOptions("conType2");
  }
  function calcRMSForce()
  {
	var accForce = parseFloat(document.getElementById("accForce").value);
	var constVelForce = parseFloat(document.getElementById("constVelForce").value);
	var decelForce = parseFloat(document.getElementById("decelForce").value);
	var timeA = parseFloat(document.getElementById("timeA").value);
	var timeC = parseFloat(document.getElementById("timeC").value);
	var timeD = parseFloat(document.getElementById("timeD").value);
	var timeOff = parseFloat(document.getElementById("timeOff").value);
	var e = document.getElementById("accForceUnits");
	var accForceUnits = e.options[e.selectedIndex].value;
	e = document.getElementById("constVelForceUnits");
	var constVelForceUnits = e.options[e.selectedIndex].value;
	e = document.getElementById("decelForceUnits");
	var decelForceUnits = e.options[e.selectedIndex].value;
	e = document.getElementById("fRMSUnits");
	var fRMSUnits = e.options[e.selectedIndex].value;
	var fRMS;
	
	document.getElementById("timeOn").value=parseFloat(timeA)+parseFloat(timeC)+parseFloat(timeD);
	
	var timeOn = document.getElementById("timeOn").value;
	
	switch(accForceUnits)
	{
		case "(lbs)":
			break;
		case "(N)":
			accForce=accForce*0.224808942443;
			break;
	}
	switch(constVelForceUnits)
	{
		case "(lbs)":
			break;
		case "(N)":
			constVelForce=constVelForce*0.224808942443;
			break;
	}
	switch(decelForceUnits)
	{
		case "(lbs)":
			break;
		case "(N)":
			decelForce=decelForce*0.224808942443;
			break;
	}
	switch(fRMSUnits)
	{
		case "(lbs)":
			fRMS=Math.sqrt(((Math.pow(accForce,2)*timeA)+(Math.pow(constVelForce,2)*timeC)+(Math.pow(decelForce,2)*timeD))/(Number(timeOn)+Number(timeOff)));
			document.getElementById("fRMS").value= round5(fRMS);
			break;
		case "(N)":
		    fRMS=Math.sqrt(((Math.pow(accForce,2)*timeA)+(Math.pow(constVelForce,2)*timeC)+(Math.pow(decelForce,2)*timeD))/(Number(timeOn)+Number(timeOff)));
			fRMS=fRMS*4.448221628254617;
		    document.getElementById("fRMS").value= round5(fRMS);
			break;
	}
  }
  function calcForce()
  {
	var mass = parseFloat(document.getElementById("mass").value);
	var acc = parseFloat(document.getElementById("acc").value);
	var e = document.getElementById("massUnit");
	var massUnit = e.options[e.selectedIndex].value;e.options[e.selectedIndex].value;
	e = document.getElementById("accUnit");
	var accUnit =  e.options[e.selectedIndex].value;
	e = document.getElementById("forceUnit");
	var forceUnit =  e.options[e.selectedIndex].value;
	var force;
	
	switch(massUnit)
	{
		case "(lbs)":
			break;
		case "(kg)":
			mass = mass/0.453592;
			break;
	}
	switch(accUnit)
	{
		case "(Gs)":
			break;
		case "(m/s^2)":
			acc = acc/9.80665;
			break;
	}
	switch(forceUnit)
	{
		case "(lbs)":
			force = mass*acc;
			break;
		case "(N)":
			force = mass*acc*4.448221628254617;
			break;
	}
		
	document.getElementById("force").value = round5(force);
  }
  function calcTriVel()
  {
	var dist = parseFloat(document.getElementById("dist1").value);
	var time = parseFloat(document.getElementById("time1").value);
	var e = document.getElementById("distUnit1");
	var distUnit = e.options[e.selectedIndex].value;
	e = document.getElementById("accUnit1");
	var accUnit = e.options[e.selectedIndex].value;
	var grvConst;
	var acc;
	
	switch(distUnit)
	{
		case "(in)":
			grvConst = 386;
			document.getElementById("triAccUnit").selectedIndex = 0;
			document.getElementById("triAccG").value=grvConst;
			break;
		case "(m)":
			grvConst = 9.81;
			document.getElementById("triAccUnit").selectedIndex = 1;
			document.getElementById("triAccG").value=grvConst;
			break;
	}
	
	switch(accUnit)
	{
		case "(Gs)":
			acc = (4*dist)/((Math.pow(time,2))*grvConst);
			break;
		case "(m/s^2)":
			acc = (4*dist)/((Math.pow(time,2))*grvConst);
			acc=acc*9.81;
			break;
	}
	
	document.getElementById("acc1").value = round5(acc);
  }
  function calcTrapVel()
  {
	var dist = parseFloat(document.getElementById("dist2").value);
	var time = parseFloat(document.getElementById("time2").value);
	var vel = parseFloat(document.getElementById("vel2").value);
	
	var e = document.getElementById("accUnit2");
	var accUnit = e.options[e.selectedIndex].value;
	var grvConst;
	var acc;
	
	var knowns = document.getElementsByName("trapvel");
	var known;
	for(var i=0;i<knowns.length;++i)
	{
		if(knowns[i].checked == true)
		{
			known = knowns[i].value;
		}
	}
	
	switch(known)
	{
		case "dt":
			document.getElementById("dist2").disabled = false;
			document.getElementById("distUnit2").disabled = false;
			document.getElementById("time2").disabled = false;
			document.getElementById("velUnit2").disabled = true;
			document.getElementById("vel2").disabled = true;
			
			e = document.getElementById("distUnit2");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in)":
					grvConst = 386;
					document.getElementById("trapAccUnit").selectedIndex = 0;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 0;
					acc = (2*dist)/((Math.pow(time,2))*grvConst);
					break;
				case "(m)":
					grvConst = 9.81;
					document.getElementById("trapAccUnit").selectedIndex = 1;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 1;
					acc = (2*dist)/((Math.pow(time,2))*grvConst);
					break;
			}
			break;
			
		case "vd":
			document.getElementById("dist2").disabled = false;
			document.getElementById("distUnit2").disabled = false;
			document.getElementById("time2").disabled = true;
			document.getElementById("velUnit2").disabled = true;
			document.getElementById("vel2").disabled = false;
			
			e = document.getElementById("distUnit2");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in)":
					grvConst = 386;
					document.getElementById("trapAccUnit").selectedIndex = 0;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 0;
					acc = (Math.pow(vel, 2))/(dist*grvConst);
					break;
				case "(m)":
					grvConst = 9.81;
					document.getElementById("trapAccUnit").selectedIndex = 1;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 1;
					acc = (Math.pow(vel, 2))/(dist*grvConst);
					break;
			}
			break;
			
		case "tv":
			document.getElementById("dist2").disabled = true;
			document.getElementById("distUnit2").disabled = true;
			document.getElementById("time2").disabled = false;
			document.getElementById("velUnit2").disabled = false;
			document.getElementById("vel2").disabled = false;
			
			e = document.getElementById("velUnit2");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in/sec)":
					grvConst = 386;
					document.getElementById("trapAccUnit").selectedIndex = 0;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 0;
					acc = (2*vel)/(time*grvConst);
					break;
				case "(m/sec)":
					grvConst = 9.81;
					document.getElementById("trapAccUnit").selectedIndex = 1;
					document.getElementById("trapAccG").value=grvConst;
					document.getElementById("velUnit2").selectedIndex = 1;
					acc = (2*vel)/(time*grvConst);
					break;
			}
			break;
	}
	
	switch(accUnit)
	{
		case "(Gs)":
			break;
		case "(m/s^2)":
			acc=acc*9.81;
			break;
	}
	
	document.getElementById("acc2").value = round5(acc);
  }
  function calcSinVel()
  {
	var dist = parseFloat(document.getElementById("dist3").value);
	var freq = parseFloat(document.getElementById("freq3").value);
	var vel = parseFloat(document.getElementById("vel3").value);
	
	var e = document.getElementById("accUnit3");
	var accUnit = e.options[e.selectedIndex].value;
	var grvConst;
	var acc;
	
	var knowns = document.getElementsByName("sinvel");
	var known;
	for(var i=0;i<knowns.length;++i)
	{
		if(knowns[i].checked == true)
		{
			known = knowns[i].value;
		}
	}
	
	switch(known)
	{
		case "fd":
			document.getElementById("dist3").disabled = false;
			document.getElementById("distUnit3").disabled = false;
			document.getElementById("freq3").disabled = false;
			document.getElementById("velUnit3").disabled = true;
			document.getElementById("vel3").disabled = true;
			
			e = document.getElementById("distUnit3");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in)":
					grvConst = 386;
					document.getElementById("sinAccUnit").selectedIndex = 0;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 0;
					acc = (2*Math.pow(3.14159265359, 2)*Math.pow(freq, 2)*dist)/(grvConst);
					break;
				case "(m)":
					grvConst = 9.81;
					document.getElementById("sinAccUnit").selectedIndex = 1;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 1;
					acc = (2*Math.pow(3.14159265359, 2)*Math.pow(freq, 2)*dist)/(grvConst);
					break;
			}
			break;
			
		case "dv":
			document.getElementById("dist3").disabled = false;
			document.getElementById("distUnit3").disabled = false;
			document.getElementById("freq3").disabled = true;
			document.getElementById("velUnit3").disabled = true;
			document.getElementById("vel3").disabled = false;
			
			e = document.getElementById("distUnit3");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in)":
					grvConst = 386;
					document.getElementById("sinAccUnit").selectedIndex = 0;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 0;
					acc = (2*Math.pow(vel, 2))/(dist*grvConst);
					break;
				case "(m)":
					grvConst = 9.81;
					document.getElementById("sinAccUnit").selectedIndex = 1;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 1;
					acc = (2*Math.pow(vel, 2))/(dist*grvConst);
					break;
			}
			break;
			
		case "vf":
			document.getElementById("dist3").disabled = true;
			document.getElementById("distUnit3").disabled = true;
			document.getElementById("freq3").disabled = false;
			document.getElementById("velUnit3").disabled = false;
			document.getElementById("vel3").disabled = false;
			
			e = document.getElementById("velUnit3");
			var unit = e.options[e.selectedIndex].value;
			
			switch(unit)
			{
				case "(in/sec)":
					grvConst = 386;
					document.getElementById("sinAccUnit").selectedIndex = 0;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 0;
					acc = (2*3.14159265359*freq*vel)/(grvConst);
					break;
				case "(m/sec)":
					grvConst = 9.81;
					document.getElementById("sinAccUnit").selectedIndex = 1;
					document.getElementById("sinAccG").value=grvConst;
					document.getElementById("velUnit3").selectedIndex = 1;
					acc = (2*3.14159265359*freq*vel)/(grvConst);
					break;
			}
			break;
	}
	
	switch(accUnit)
	{
		case "(Gs)":
			break;
		case "(m/s^2)":
			acc=acc*9.81;
			break;
	}
	
	document.getElementById("acc3").value = round5(acc);
  }
  function calcDutyCycle()
  {
	var timeOn = parseFloat(document.getElementById("timeOnDC").value);
	var timeOff = parseFloat(document.getElementById("timeOffDC").value);
	var dutyCycle;
	
	dutyCycle = (timeOn/(timeOn+timeOff))*100;
	document.getElementById("dutyCycle").value = round5(dutyCycle);
  }
  function calcForceAtDutyCycle()
  {
    var forceAt100 = parseFloat(document.getElementById("forceAtDC").value);
	var dutyCycle = parseFloat(document.getElementById("dutyCycleV").value)/100;
	var force;
	
	force = forceAt100*Math.sqrt(1/dutyCycle);
	document.getElementById("forceAt").value=round5(force);
  }
  function round5(f)
  {
	var temp = f*100000;
	temp = Math.round(temp);
	return temp/100000;
  }