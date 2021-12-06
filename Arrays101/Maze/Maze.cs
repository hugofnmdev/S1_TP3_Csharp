using System;

namespace Maze
{
    public static class Maze
    {
        public const char SpaceChar = ' ';
        public const char WallChar = '#';
        public const char StartChar = '@';
        public const char EndChar = 'x';
        public const char PathChar = 'o';

        /**
         * <summary>Looks for the character '@' in a matrix.</summary>
         * <param name="maze">A characters matrix representing a maze.</param>
         * <param name="x">A reference to the x coordinate of '@'</param>
         * <param name="y">A reference to the y coordinate of '@'</param>
         * <returns>Returns <c>true</c> if the character was found, else <c>false</c></returns>
         */
        public static bool FindStart(char[,] maze, ref int x, ref int y)
        {
            throw new NotImplementedException();
        }

        /**
         * <summary>Writes a maze in the standard output</summary>
         * <example>
         * <code>
         * char[,] maze = {
         *      {'#', 'x', '#', '#', '#', '#'},
         *      {'#', ' ', '#', ' ', ' ', '#'},
         *      {'#', ' ', ' ', ' ', ' ', '#'},
         *      {'#', '#', ' ', '#', ' ', '#'},
         *      {'#', ' ', ' ', '#', ' ', '#'},
         *      {'#', ' ', '#', '#', '#', '#'},
         *      {'#', ' ', ' ', ' ', ' ', '#'},
         *      {'#', '#', '#', '#', '@', '#'},
         * };
         * Maze.Print(maze);
         * </code>
         * Outputs the following:
         * <code>
         * ##xx########
         * ##  ##    ##
         * ##        ##
         * ####  ##  ##
         * ##    ##  ##
         * ##  ########
         * ##        ##
         * ########@@##
         * </code>
         * </example>
         */
        public static void Print(char[,] maze)
        {
            throw new NotImplementedException();
        }

        /**
         * <summary>Checks if a maze contains a valid path,
         * i.e. a path from the starting point to the destination.</summary>
         * <param name="maze">A characters matrix representing a maze.</param>
         * <returns>True if <c>maze</c> contains a valid path.</returns>
         */
        public static bool IsPathValid(char[,] maze)
        {
            throw new NotImplementedException();
        }

        /**
         * <summary>Finds a valid path from the starting point to the
         * destination and mark it in the matrix with the character 'o'.
         * If their is no such path, the maze is left unchanged.</summary>
         * <param name="maze">A characters matrix representing a maze.</param>
         */
        public static void FindPath(char[,] maze)
        {
            throw new NotImplementedException();
        }

        /**
         * <summary>Generate a maze.</summary>
         * <param name="width">The width of the output maze - at least 4.</param>
         * <param name="height">The height of the output maze - at least 4.</param>
         * <returns>Returns a matrix of size <c>width</c>x<c>height</c>.</returns>
         *
         * BONUS
         */
        public static char[,] Generate(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}