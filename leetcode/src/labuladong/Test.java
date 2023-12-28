package labuladong;

import org.omg.PortableInterceptor.INACTIVE;

import java.lang.reflect.Array;
import java.util.*;
public class Test {
    int maxA(int N){
        int[] dp = new int[N+1];
        dp[0] = 0;
        for (int i = 1; i <=N ; i++) {
            dp[i] = dp[i-1]+1;
            for (int j=2;j<i;j++){
                dp[i] = Math.max(dp[i],dp[j-2]*(i-j+1));
            }
        }
        return dp[N];
        
    }

}
