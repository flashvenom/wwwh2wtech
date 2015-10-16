function linkUnits(elemStatic, elemVar) // ElemVar must have innerHTML editable
{
	elemStatic = document.getElementById(elemStatic);
	elemVar = document.getElementById(elemVar);
	elemVar.innerHTML = elemStatic.value;
}

function linkUnitsChange(elemStatic, elemVar, sFirst, sSecond) // elemVar needs innerHTML, sFirst and second are the units for the first and second selected units
{
	elemStatic = document.getElementById(elemStatic);
	elemVar = document.getElementById(elemVar);
	var selIndex = elemStatic.selectedIndex;
	
	if(selIndex == 0)
		elemVar.innerHTML = sFirst;
	else if(selIndex == 1)
		elemVar.innerHTML = sSecond;
}

function switchNumber(elemStatic, elemVar, iFirst, iSecond)
{
	elemStatic = document.getElementById(elemStatic);
	elemVar = document.getElementById(elemVar);
	var selIndex = elemStatic.selectedIndex;
	
	if(selIndex == 0)
	{
		elemVar.value = iFirst;
	}
	else if(selIndex == 1)
	{
		elemVar.value = iSecond;
	}
}