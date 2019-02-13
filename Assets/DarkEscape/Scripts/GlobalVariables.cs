public static class GlobalVariables {
	// Indicates when the game is started
	public static bool gameStarted = false;

	// Indicates when the user gets the card
	public static bool hasCard = false;

	// Indicates when the game is completed
	public static bool gameCompleted = false;

	// Indicates when the game is over
	public static bool gameOver = false;

	// Indicates the Exploration Points
	public static float explorationPoints = 0;

	// Indicates the Remaining Time
	public static float remainingTime = 0;

	public static void ResetVariables () {
		gameStarted 		= false;
		hasCard 			= false;
		gameCompleted 		= false;
		gameOver 			= false;
		explorationPoints 	= 0;
		remainingTime 		= 0;
	}
}