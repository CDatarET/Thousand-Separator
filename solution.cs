public class Solution {
    private string builder(int n){
        StringBuilder sb = new StringBuilder();
        int i = 1;
        while(n > 0){
            sb.Append(n % 10);
            n /= 10;

            if(i++ % 3 == 0 && n > 0) sb.Append('.');
        }

        return(new string(sb.ToString().Reverse().ToArray()));
    }

    public string ThousandSeparator(int n) {
        if(n <= 999) return("" + n);

        return(builder(n));
    }
}
