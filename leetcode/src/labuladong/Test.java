package labuladong;

import java.util.LinkedList;
import java.util.List;

public class Test {
    static int coinChange(int[] coins, int amount){
        // dp[i]= x 当目标金额为i时，至少需要x枚硬币
        int[] dp = new int[amount+1];
        for (int i = 0; i < dp.length; i++) {
            dp[i] = amount+1;
        }
        dp[0] = 0;
        for (int i =0; i<dp.length;i++){
            for (int coin:coins){
                if (i - coin < 0) continue;
                dp[i] = Integer.min(dp[i],1+dp[i-coin]);
            }
        }
        return dp[amount] == amount+1 ? -1:dp[amount];
    }
    List<List<Integer>> res = new LinkedList<>();
    int[][] board;
    List<List<Integer>> nQueen(int nums){
        LinkedList<Integer> track = new LinkedList<>();
        board = new int[nums][nums];
        backtrack(nums,track);
        System.out.println(res);
        return res;
    }
    void backtrack(int n, LinkedList<Integer> track){
        if (track.size() == n){
            res.add(new LinkedList<>(track));
            return;
        }
        for (int i = 0; i < n; i++) {
            if (okPut(n,i)){
                board[n][i] = 1;
                track.add(i);
                backtrack(n+1,track);
                board[n][i] = 0;
                track.removeLast();
            }

        }
    }

    private boolean okPut(int n, int i) {
        for (int j = 0; j < n; j++) {
            if (board[j][i] == 1 || board[j][i-j] == 1)
                return false;

        }
        return true;
    }
}
