// Easy way to get the text of a combobox
function getSelectedText(elementId) {
    var elt = document.getElementById(elementId);

    if (elt.selectedIndex == -1)
        return null;

    return elt.options[elt.selectedIndex].text;
}

function recalculate()
{
	// Row gets the row of the hidden table where all the motor data is stored
	var row = document.getElementById(getSelectedText("vcs-selection"));
	var PF, CF, ETC, STR, MM, MC, inSTR, inPAY;
	var maxFreq, contFreq;
	
	inSTR = Number(document.getElementById("stroke").value);
	inPAY = Number(document.getElementById("payload").value);
	
	var e = document.getElementById("strk-selection");
	var STRUnit = e.options[e.selectedIndex].value;
	var e = document.getElementById("pay-selection");
	var PAYUnit = e.options[e.selectedIndex].value;
	
	for(i = 0; i < row.cells.length; i++)
	{
		// Getting and parsing the data from the table
		var dat = row.cells.item(i).innerHTML;
		var datS = dat.split(":");
		
		// Just assignment to variables
		switch(datS[0])
		{
			case "Force @ 10% Duty":
				PF = Number(datS[1]);
				break;
			case "Force @ 100% Duty":
				CF = Number(datS[1]);
				break;
			case "Electrical Time Constant":
				ETC = Number(datS[1]);
				break;
			case "Stroke":
				STR = Number(datS[1]);
				break;
			case "Moving Mass":
				MM = Number(datS[1]);
				break;
			case "Motor Constant":
				MC = Number(datS[1]);
				break;
		}
	}
	
	// Limiting stroke input to max of motor stroke
	switch(STRUnit)
	{			
		case "in":
			//STR = roundP(STR/25.4, 3); // Convert stored stroke to inches
			inSTR = roundP(inSTR*25.4, 3); // Convert input to millimeters
			break;
	}
	if(inSTR < 0)
	{
		inSTR = 0;
		document.getElementById("stroke").value = 0;
	}
	else if(inSTR > STR)
	{
		inSTR = STR;
		if(STRUnit == "in")
			document.getElementById("stroke").value = roundP(STR/25.4, 3); // Switch back to inches to display if that's the unit
		else
			document.getElementById("stroke").value = STR;
		
	}
	
	// Limit payload to positive
	if(inPAY < 0)
	{
		inPAY = 0;
		document.getElementById("payload").value = 0;
	}
	
	// Payload unit conversion, converting to grams
	switch(PAYUnit)
	{
		case "g":
			break;
			
		case "N":
			inPAY = inPAY*101.972;
			break;
			
		case "lb":
			inPAY = inPAY*453.592;
			break;
	}
	
	// The actual calculations
	var totalMovingMass = MM + inPAY;
	var maxAcc = roundP((1000 * (PF / totalMovingMass))/9.81, 2);
	
	var sinMaxFreqPK = 225.08 * Math.sqrt(PF / (inSTR * totalMovingMass));
	var triMaxFreqPK = sinMaxFreqPK * 0.25 / 0.225;
	var sinMaxFreqCont = 225.08 * Math.sqrt(CF / (inSTR * totalMovingMass));
	var triMaxFreqCont = sinMaxFreqCont * 0.25 / 0.225;
	
	maxFreq = roundP(sinMaxFreqPK, 2);
	contFreq = roundP(sinMaxFreqCont, 2);
	
	document.getElementById("cont").value = contFreq + " Hz";
	
}
function find()
{
	// Inputs
	var str = Number(document.getElementById("stroke-ps").value);
	var freq = Number(document.getElementById("frequency-ps").value);
	var pay = Number(document.getElementById("payload-ps").value);
	
	// Calculating the force required based on inputs
	var force = Math.pow((freq / 225.08), 2) * str * (pay + 100);
	force = roundP(force, 2);
	
	document.getElementById("force-ps").value = force + " N";
	
	var dataTbl = document.getElementById("prodDataHidden");
	var prodTbl = document.getElementById("productSelector");
	
	// Clear the table
	for(var i = 0; i < prodTbl.rows.length; i++)
	{
		if(i > 0)
		{
			prodTbl[i].style.display="none";
		}
	}
	//Repopulate the table
	for(var i = 0, row; row = dataTbl.rows[i]; i++)
	{
		var CF, STR;
		var rowCount = prodTbl.rows.length;
		for(var j = 0, col; col = row.cells[j]; j++)
		{
			var dat = col.innerHTML;
			var datS = dat.split(":");
		
			switch(datS[0])
			{
				case "Force @ 100% Duty":
					CF = Number(datS[1]);
					break;
				case "Stroke":
					STR = Number(datS[1]);
					break;
			}
		}
		// If the product matches our search parameters
		if(STR > str && STR < str * 100 && CF > (force - (force * .5)) && CF < force * 10)
		{
			prodTbl[i+1].style.dsplay="";
		}
	}
}

function roundP(num, p)
{
	var temp = num * Math.pow(10, p);
	temp = Math.round(temp);
	return temp / Math.pow(10, p);
}