Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
 

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.

CODE:

public class Solution {
    public void Bfs(char[][] grid, int startRow, int startCol){
        int rows = grid.Length;
        int cols = grid[0].Length;

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[]{startRow,startCol});
        grid[startRow][startCol]='0';

        while(queue.Count>0){
            int[] cell = queue.Dequeue();
            int row = cell[0];
            int col = cell[1];

            //up
            if(row-1>=0 && grid[row-1][col]=='1'){
                grid[row-1][col]='0';
                queue.Enqueue(new int[]{row-1,col});
            }

            //down
            if(row+1<rows && grid[row+1][col]=='1'){
                grid[row+1][col]='0';
                queue.Enqueue(new int[]{row+1,col});
            }

            //left
            if(col-1>=0 && grid[row][col-1]=='1'){
                grid[row][col-1]='0';
                queue.Enqueue(new int[]{row,col-1});
            }

            //right
            if(col+1<cols && grid[row][col+1]=='1'){
                grid[row][col+1]='0';
                queue.Enqueue(new int[]{row,col+1});
            }
        }

    }
    public int NumIslands(char[][] grid) {
        if(grid==null || grid.Length==0){
            return 0;
        }

        int islandCount = 0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                if(grid[i][j]=='1'){
                    islandCount++;
                    Bfs(grid,i,j);
                }
            }
        }
        return islandCount;
    }
}

OUTPUT:

Runtime
143
ms
Beats
23.68%
