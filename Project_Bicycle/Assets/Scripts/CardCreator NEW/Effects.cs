using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect {
	public int Duration;
	public int Value;

	public Effect(){

	}
}

public abstract class TargetedEffect : Effect{
	//public Shape Shape;
	//public Tag[] Affecting;
	public int[] Range;
	public int Size;

	public TargetedEffect() : base(){
		
	}
}

/*************Non-targeted Effects*************/
public class DrawEffect : Effect{
	public DrawEffect() : base(){
		
	}
}

public class DiscardEffect : Effect{
	public DiscardEffect() : base(){
		
	}
}

public class ManaEffect : Effect{
	public ManaEffect() : base(){
		
	}
}

/***************Targeted Effects***************/
public class MovementEffect : TargetedEffect{
	public MovementEffect() : base(){
	}
}

public class HealingEffect : TargetedEffect{
	public HealingEffect() : base(){
	}
}

public class DamageEffect : TargetedEffect{
	public DamageEffect() : base(){
	}
}

public class BuffEffect : TargetedEffect{
	public BuffEffect() : base(){
	}
}

public class CreateEffect : TargetedEffect{
	public GameObject Entity;

	public CreateEffect() : base(){

	}
}
