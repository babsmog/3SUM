public class Solution {
     static bool binary_search(int l,int r,int[]nums, int x)
    {
        while(l<=r)
        {
            int mid=(l+r)/2;
            if(nums[mid]==x) return true;
            else if(nums[mid]>x) r=mid-1;
            else l=mid+1;
        }
        return false;
    }
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        var ans = new List<IList<int>>();
        Array.Sort(nums);
        //ArrayList.Sort(nums);
        //nums.Sort(nums[0],nums.Length);
         //Sort(nums.begin(),nums.end());
       // var snums = nums.Cast<string>().OrderBy(item => int.Parse(item));
        int n=nums.Length;
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(binary_search(j+1,n-1,nums,-(nums[i]+nums[j])))
                {
                    List<int> t = new  List<int>();
                    t.Add(nums[i]);
                    t.Add(nums[j]);
                    t.Add(-(nums[i]+nums[j]));
                    ans.Add(t);
                }
                
                while(j+1<n && nums[j+1]==nums[j]) j++;
            }
            
            while(i+1<n && nums[i+1]==nums[i]) i++;
        }
        
        return ans; 
        
    }
}
