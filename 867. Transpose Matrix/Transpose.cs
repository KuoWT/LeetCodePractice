public class Solution {
    public int[][] Transpose(int[][] matrix) {
        
        int[][] results = new int[matrix[0].Length][];
        for(int i = 0;i<matrix[0].Length;i++)
        {
            results[i] = new int[matrix.Length];
        }
        
        for(int col = 0;col<matrix.Length;col++)
        {
            for(int row = 0;row<matrix[col].Length;row++)
            {
                results[row][col]=matrix[col][row];
            }
        }
        return results;
    }
}