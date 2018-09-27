namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{            
            For(Direction.Right, robot, width-3);
            For(Direction.Down, robot,2);
            For(Direction.Left, robot, width - 3);           
            while (robot.Finished!=true)
            {
                For(Direction.Down, robot,2);
                For(Direction.Right, robot, width - 3);
                For(Direction.Down, robot,2);
                For(Direction.Left, robot, width - 3);
            }           
        }

        static void For(Direction direction, Robot robot, int width)
        {
            for (int i = 0; i < width; i++)
            {
                robot.MoveTo(direction);
            }
        }       
    }
}