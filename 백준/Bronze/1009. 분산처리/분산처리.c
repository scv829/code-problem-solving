#include <stdio.h>
#include <stdlib.h>

int main()
{
    int lan=0,i,j;
    scanf("%d",&lan);

    int a[lan], b[lan], answer[lan];

    for(i = 0; i < lan; i++){
        answer[i] = 1;
        scanf("%d %d",&a[i],&b[i]);
        for(j = 0; j < b[i]; j++){
            answer[i] = (answer[i] * a[i]) % 10;
            if(answer[i] == 0) answer[i] = 10;
        }
        printf("%d\n",answer[i]);
    }

    return 0;
}
