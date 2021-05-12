export default{
    validateName(val){
       var arrNum = [0,1,2,3,4,5,6,7,8,9];
       arrNum.forEach(element => {
           if(val.indexOF(element) == -1)
                return false;
       });
       return true;
    }
}