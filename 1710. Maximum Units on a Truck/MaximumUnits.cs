public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        int max = 0;int truck = 0;
          List<int[]> query = (from item in boxTypes orderby  item[1] descending  select item).ToList();
          for(int i =0;i<query.Count();i++)
          {
               for(int j =query[i][0];j>0;j--)
               {
                    truck++;
                    if(truck<=truckSize)
                    {
                         max = max + query[i][1];
                    }
               }
          }
          return max;
    }
}