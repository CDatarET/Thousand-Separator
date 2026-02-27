class Solution {
    private String builder(int n){
        StringBuilder sb = new StringBuilder();
        int i = 1;
        while(n > 0){
            sb.append(n % 10);
            n /= 10;

            if(i++ % 3 == 0 && n > 0){
                sb.append('.');
            }
        }

        sb.reverse();
        return(sb.toString());
    }

    public String thousandSeparator(int n){
        if(n <= 999){
            return("" + n);
        }

        return(builder(n));
    }
}
