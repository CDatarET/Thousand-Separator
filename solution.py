class Solution:
    def builder(self, n):
        num = []
        i = 1
        while n > 0:
            num.append(str(n % 10))
            n //= 10
        
            if i % 3 == 0 and n > 0:
                num.append(".")
        
            i += 1
        
        return("".join(num)[::-1])

    def thousandSeparator(self, n):
        if n <= 999:
            return str(n)
            
        return(self.builder(n))
