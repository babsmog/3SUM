# 3SUM
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Example 2:

Input: nums = []
Output: []
Example 3:

Input: nums = [0]
Output: []
 

Constraints:

0 <= nums.length <= 3000
-105 <= nums[i] <= 105

#**Solution (Brute Force + Binary Search)**
we need to find unique triplets with a+b+c =0, let’s say we know the value of a and b, using the equation( a+b+c =0 ) we can find the value of c, which is -(a+b).

if we take all the possible (a,b) pairs, we can get all pairs of a,b using 2 nested for loops. after that, we can use binary search to know if c=-(a+b) exists in the given array or not.
if it exists then the triplet (a,b,-(a+b)) will be a possible triplet. in this way, we will get all the possible triplets with a+b+c=0, but we need to find the unique triplets,
for that we can insert all these possible triplets in some data structure( i.e. set) to get unique triplets.

Time Complexity
O(N*N*log(N)): we are using two nested for loops to get all the possible (a,b) pair and a Binary search to know if -(a+b) exists in the array or not.
Space Complexity 
O(N): we are using a set to get unique triplets.
