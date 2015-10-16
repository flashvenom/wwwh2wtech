var VCSdesc = "Voice Coil Linear Positioning Stages are designed for a variety of short stroke and high velocity applications. They have stroke lengths of up to 2.0 in. (50 mm), continuous forces as high as&nbsp;200 lbs (908 N) and peak forces of up to 600 lbs (2670 N). They are ideal for short-stroke closed-loop positioning applications where intricate position, velocity, and acceleration control is necessary. They have a compact size that allows them to fit into small spaces. The stages have very low electrical and mechanical time constants. The low moving masses allow for high accelerations of light payloads. The iron-less core coil assembly has no magnetic attractive force to the stationary magnet assembly, which reduces the load on the bearing system, increasing the life of the bearing. There are reduced magnetic drag forces (hysteresis), which allows for higher accelerations. These actuators are wound in such a way that no commutation is required for motion to occur. Electrical devices such as Hall Effects are not necessary. The result is a much simpler and more reliable system.";

function getDesc(prod)
{
	switch(prod)
	{
		case "VCS":
			return VCSdesc;
			break;
		
		default:
			return "Unknown Product.";
			break;
	}
}