//*****************************************************************************
//** 2900. Longest Unequal Adjacent Groups Subsequence I            leetcode **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
char** getLongestSubsequence(char** words, int wordsSize, int* groups, int groupsSize, int* returnSize) {
    char** ans = (char**)malloc(wordsSize * sizeof(char*));
    int count = 0;
    int hashbrown = -1;

    for (int i = 0; i < wordsSize; i++)
    {
        if (groups[i] != hashbrown)
        {
            hashbrown = groups[i];
            ans[count] = (char*)malloc(strlen(words[i]) + 1);
            strcpy(ans[count], words[i]);
            count++;
        }
    }

    *returnSize = count;
    return ans;
}