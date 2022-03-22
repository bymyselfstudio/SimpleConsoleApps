/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 *
 * HOW LONG WILL IT TAKE TO DOUBLE A SPECIFIC AMOUNT OF MONEY ONLY BY YIELD INTEREST 
 */
package moneyproject;

public class MoneyProject {

    public static void main(String[] args) {
       Money m = new Money(20,10,3);
       m.Result(); 
    } 
}

class Money{
    
    float k, k1, p;
    byte y = 0;
    
    public Money(float _limit, float _input, float _p){
        this.k = _limit;
        this.k1 = _input;
        this.p = _p;
    }
    
    public void Result(){
        do {
            k1 = k1 * (1 + p / 100);
            y++;
        }
        while (k1 < k);
        System.out.println("Years for doubling the amount: " + y);
        System.out.println("Final amount: " + k1);
    }
}

