TopDownShooter
==============
This is a top-down shooter game that is based in Unity. 

The game consists of a player that is in the middle of the screen and 
forced to fight countless enemies in order to survive. 

The player himself is a primative sphere that can be altered easily. 

The enemies are primative cubes that detect where the player is and try 
to collide with him.

The goal of the game is to stay alive for as long as possible. 

Once the player eventually dies, a splash screen will come up that 
shows the kill count and time survived. 

You can then click the play button to play another game or exit button 
to quit the application.


//////////////////////////////////////////////////////////////////////////
///   ISSUES THAT STILL NEED TO BE WORKED OUT                          ///
///   1)  kill count doesn't work                                      ///
///   2)  enemies still spawn at same time                             ///
///   3)  time doesn't reset if play button is hit again               ///
///   4)  bullets spawn in front of player, not in front of gun.       ///
///       As a result, the bullets instantiate inside of the gun       ///
///       when the player is facing downwards and don't appear to      ///
///       shoot.                                                       ///
//////////////////////////////////////////////////////////////////////////
