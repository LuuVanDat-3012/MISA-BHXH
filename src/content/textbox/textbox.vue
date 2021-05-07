<template>
    <div class="textbox-model">
        <div class="tb-name">{{tbName}}</div>
        <div class="input-box">
              <input type="text" name="customerName">
        </div>
    </div>
</template>
<script>
export default {
    name:"MSTextbox",
    props:{
        tbName: {
            typeof: String
        }
    }
}
</script>
<style>
.textbox-model{
    height: 100px;
    width: 284px;
    display: flex;
    flex-direction: column;
}
.tb-name{
    font-size: 13px;
    height: 24px;
    width: 100%;
}
.input-box{
    flex: 1;
}
.input-box input{
    width: 100%;
    height: 100%;
}

</style>