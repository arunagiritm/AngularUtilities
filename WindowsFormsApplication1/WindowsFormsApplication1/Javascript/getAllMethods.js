function getAllMethods(){
 
    this.getAllMethods=function(objname){
        var methodcollection=[];
        var methodcollectionProto=[];
        methodcollection= getMethodsName(objname);
        methodcollectionProto=getMethodsName(Object.getPrototypeOf(objname));
        return methodcollection.concat(methodcollectionProto);
    }
    
    this.samplemethod=function(arg1,arg2){
        alert();
    }
    

    
    function argumentNames(fn){
    var fstr = fn.toString();
    return fstr.match(/\(.*?\)/)[0].replace(/[()]/gi,'').replace(/\s/gi,'').split(',');
    }
    getMethodsName=function (objName) {
        var aMethods=[];
        var tMethods={};
        tMethods.functionName="";
        tMethods.args=[];
       Object.getOwnPropertyNames(objName).filter(function (memberName) {
            tMethods={};
            if(typeof objName[memberName] === "function"){
                tMethods.functionName=memberName;
                tMethods.args= argumentNames(objName[memberName]);
                aMethods.push(tMethods);
            }
        });
        
        return aMethods;
    }
    
}
/*getAllMethods.prototype.protosample=function(a,b,c,d,e){};*/
