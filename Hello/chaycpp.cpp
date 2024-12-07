#include<stdio.h>
#include<conio.h>
#include "unistd.h"
#include "graphics.h"
int main(){
int gm,gd=DETECT;
initgraph(&gd,&gm,"c:\\tc\\bgi");
setfillstyle(12,4);
bar(100,0,500,310);
int s[]={300,30,338,118,443,123,360,178,383,283,300,223,215,283,240,178,158,123,262,118};
setfillstyle(12,14);
fillpoly(10,s);
 getch();
 closegraph();
 return 0;
}