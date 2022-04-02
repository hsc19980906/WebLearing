//2.4变量
//(1)赋值操作会自动声明变量
// mood="happy";
// age=23;
//(2)但推荐提前声明变量
// var mood,age;
//(3)还可以把声明和赋值操作放在一起
// var mood="happy",age=23;
// alert(mood);
// alert(age);
//2.4.2数组
//(1)声明数组
// var beatles=Array(4);//声明数组且给出数组个数
// var beatles_Alot=Array();//未知个数
//(2)填充（添加元素）array[index]=element;
// beatles[0]="john";beatles[1]="paul";beatles[2]="george";beatles[3]="ringo";
// var beatles=Array("john","paul","george","ringo");//声明的同时进行填充
// var beatles=["john","paul","george","ringo"];//可以不声明创建数组类型，但不推荐
// var lennon=Array("john",1940,false);//可以混合类型放置在同一数组
//(3)关联数组(所有的数组都可以看做关联数组，只不过普通数组的索引是0、1、2...)
// var lennon=Array();
// lennon["name"]="john";lennon["year"]=1940;lennon["living"]=false;
//2.5操作
//(1)算数运算符+-*/，++，--；+可以用于连接两个字符串（拼接）;+=可以完成一次“加法/拼接+赋值”
// alert("10"+20);//1020
// alert(10+20);//30
//(2)比较操作符>;<;>=;<=;==;!=
//(3)逻辑操作符&&;||;!;
//2.8函数
//(1)无参无返
// shout();
// function shout() {
//     var beatles=Array("john","paul","george","ringo");
//     for (var index = 0; index < beatles.length; index++) {
//         alert(beatles[index]);
//     }
// }
//(2)有参无返
// function multiply(num1,num2) {
//     var total=num1*num2;
//     alert(total);
// }
// multiply(10,2);
//(3)有参有反
// function multiply(num1,num2) {
//     var total=num1*num2;
//     return total;
// }
//(4)函数可以作为一种数据类型使用，即可以赋值给变量
// function convertToCelsius(temp){
//     var result=temp-32;
//     result/=1.8;
//     return result;
// }
// var temp_fahrenheit=95;
// var temp_celsius=convertToCelsius(temp_fahrenheit);
// alert(temp_celsius);
//2.9对象
//(1)用户自定义对象
// var jeremy=new Person;//创建一个实例（实例时对象的具体表现，实例是个体，对象是统称）
//(2)内建对象，如Array、Math、Date等
//(3)宿主对象（由JavaScript的运行环境提供），主要包括Form、Image、Element，可以通过这些对象来获取某给定网页上的表单、图像、表单元素等信息。还有一种更常用的获取某给定网页上任何一个元素信息的方法——document对象，后续会介绍。


