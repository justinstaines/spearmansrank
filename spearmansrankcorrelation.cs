public class spearmansrank

{public static void Main()

// Spearmans rank correllation coefficient calculator (C) 2021 Justin Staines
// Feel free to use
// compile through power shell by inserting all the code in between the quote marks
// Add-Type -outputtype consoleapplication -outputassembly spearmansrank.exe ''

{
    
    int start=1;
    int difference;
    int squared;
    int sumsquared;
    int rank;
    int arraysizey = 5;
    float spearmanrank;

    string name;

    System.Console.WriteLine("Calculate Spearmans Rank Coefficient from the following sets of numbers:");

    int[,] a3 = new int[2,6] { { 36 , 52, 63, 14, 85, 0 }, { 0, 0, 0, 0, 0, 0 }};

    int[,] a2 = new int[2,6] { { 17, 24, 77, 31, 22, 0 }, { 0, 0, 0, 0, 0, 0 }};


    // These arrays are just used to hold temporary numbers

    int[,] a4 = new int[2,6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};

    int[,] a6 = new int[2,6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};

    int[,] a7 = new int[2,6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};

    int[,] a5 = new int[2,6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};

    // The resulting ranking numbers are put into a1
    
    int[,] a1 = new int[2, 6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }};
    
    int x=0;
    int y=0;

    // Copy a2 into a4

    while (y < arraysizey) {
    a4[x,y]  = a2[x,y] ;
    y++; 


    };

    // Copy a3 into a6

    x = 0;
    y = 0;
    while (y < arraysizey) {
    a6[x,y]  = a3[x,y] ;
    y++; 


    };

    
    
    while (start==1) {

// Main program loop runs while start = 1




// sort a2 into ascending order

    x = 0;
    y = 0;
    while (y < arraysizey) {
    a2[(x+1),y]  = a2[x,y] ;
    y++; 
    

    };

    int temp;
    x = 0;
    y = 0;
    while (y < 5) {
    if (a2[x,y] < a2[x,(y+1)]) { temp=a2[x,y]; a2[x,y] = a2[(x),(y+1)]; a2[x,(y+1)] = temp ;}  ;
    y++; 


    };

    

// sort a3 into ascending order

    x = 0;
    y = 0;
    while (y < arraysizey) {
    a3[(x+1),y]  = a3[x,y] ;
    y++; 
    

    };

 
    x = 0;
    y = 0;
    while (y < 5) {
    if (a3[x,y] < a3[x,(y+1)]) { temp=a3[x,y]; a3[x,y] = a3[(x),(y+1)]; a3[x,(y+1)] = temp ;}  ;
    y++; 


    };

// rank a2 and put results into a5

    x = 0;
    rank = 0;
    
    while (x < (arraysizey)) {
        y = 0;
    while (y < (arraysizey)) {
    if (a4[0, x] ==  a2[0,y]) { rank = y ; a5[0,x] = rank; }  ;
    y++; 


    };
    x++;
    };

// rank a3 and put results into a7

    x = 0;
    rank = 0;
    
    while (x < (arraysizey)) {
        y = 0;
    while (y < (arraysizey)) {
    if (a6[0, x] ==  a3[0,y]) { rank = y ; a7[0,x] = rank; }  ;
    y++; 


    };
    x++;
    };

// print a2 - first list of numbers to be ranked
    x = 0;
    y = 0;
    while (y < arraysizey) {
    System.Console.Write(a2[0,y]);
    System.Console.Write(" ");
    y++; 


    };
    System.Console.WriteLine(" ");

// print a3 - second list of numbers to be ranked

    x = 0;
    y = 0;
    while (y < arraysizey) {
    System.Console.Write(a3[x,y]);
    System.Console.Write(" ");
    y++; 


    };
    System.Console.WriteLine(" ");

// put ranked differences into a1

    x = 0;
    y = 0;
    while (y < arraysizey) {
    a1[(x+1),y]  = a7[x,y] ;
    y++; 


    };

// put second set of ranked differences into a1

    x = 0;
    y = 0;
    while (y < arraysizey) {
    a1[x,y]  = a5[x,y] ;
    y++; 


    };
   
// Perform the main Spearmans rank coefficient calculation

   sumsquared =0;
   y = 0;


    while (y < arraysizey) {
    int spearmanone = (a1[x,y]);
    int spearmantwo = (a1[(x+1),y]);
   
    if (spearmanone < spearmantwo) { difference = (spearmantwo - spearmanone) ;} else { difference = (spearmanone - spearmantwo) ;};

    squared = (difference * difference);
    sumsquared = (squared + sumsquared);
    
    y++;   };
    
    float top;
    float bottom;

    top = 6*(sumsquared);
    bottom = 5*(25-1);
    spearmanrank = 1 - (top/bottom);

    System.Console.WriteLine("The Spearman Rank Coefficient is:");
    System.Console.WriteLine(spearmanrank);
    
    name = System.Console.ReadLine();
   
    
    start = 0;
   
    }

}
    
    }