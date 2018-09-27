namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{

            int steps = 2;
            MoveDown(steps, robot, height);
            MoveRight(steps, robot, width);
        }

        public static void MoveDown(int steps, Robot robot, int height)
        {
            for (; height != steps; height--)            
            {
                robot.MoveTo(Direction.Down);
            }
        }

        public static void MoveRight(int steps, Robot robot, int width)
        {
            for (; (width != steps); width--)
            {
                robot.MoveTo(Direction.Right);
            }

        }

    }
}