<template>
    <div class="main-content">
        <div class= "content-header">
              <div class="content-header-text">
                    <h2>Danh sách khách hàng</h2>
              </div>
              <div class="content-header-button">
                    <button class="btnInsert" >
                        <img src="../../content/icon/add.png" alt="" width="20px" height="20px">
                        Thêm khách hàng
                    </button>
              </div>
        </div>

        <div class="content-input">
             <div class="input-search">
                    <button class="btnSearch"> </button>
                    <input type="text" class="search-box" placeholder="Tìm kiếm theo tên, email... ">
             </div>
            
             <MSCombobox v-bind:list = this.listDepartment></MSCombobox>
             <MSCombobox v-bind:list = this.listPosition>  </MSCombobox>
             <div class="refresh-table"> </div> 
        </div>
        <EmployeeTable v-bind:listEmployee = this.listEmployee></EmployeeTable>
        <MSNavigation></MSNavigation>


    </div>
</template>
<script>
import MSCombobox from '../../content/combobox/combobox.vue'
import EmployeeTable from  '../../content/table/EmployeeTable.vue'
import MSNavigation from '../../content/navigation/navigation.vue'
export default {
    name: "mscontent",
    components:{
        MSCombobox,
        EmployeeTable,
        MSNavigation
    },
    methods:{
        sayHi(){
            alert("Hello");
        }
    },
    data(){
        return{
             listDepartment:[
               'Tất cả phòng ban', 'Phòng tài chính', 'Phòng nhân sự', ' Phòng kế toán' 
             ],
             listPosition:[
                 'Tất cả chức vụ', 'Nhân viên kế toán', 'Nhân viên kinh đoanh', 'Bảo vệ'
             ], 
             listEmployee:[
                 {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 } ,
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },   
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 }, {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 },
                  {
                     'code': 123,
                     'name': 'Lưu Văn Đạt',
                     'sex': 'Nam',
                     'birthday':'20/12/2000',
                     'phone':'0395837186',
                     'email':'luuvandat@gmail.com',
                     'position':'Fresger Web',
                     'department':'Phòng đào tạo',
                     'salary':10000000,
                     'jobStatus': 'Học việc'
                 }
             ]   
        }
          
    }
}
</script>
<style scoped>
.main-content .content-header{
    height: 48px;
    width: 100%;
    display: flex;
    box-sizing: border-box;
    padding: 10px;
 }
    .main-content .content-header .content-header-text{
       position: absolute;
       justify-content: center;
       align-items: center;
    }
    .main-content .content-header .content-header-button{
        position: absolute;
        right: 15px;
        line-height: 50px;
      
    }
        .btnInsert{
            background-color: #019160;
            height: 40px;
            color: #fff;
            border-radius: 4px;
            border : 0;
            padding: 0 16px;
            align-content: center;
            display: flex;
            line-height: 40px;
            justify-content: center;
            align-items: center;
        }
        .btnInsert img{
            padding-right: 6px;
        }
        .btnInsert:hover {
            background-color: #2FBEBE;
            cursor: pointer;
        }

            /* .btnInsert-icon{
                 width: 35px;
                 height: 40px;
                 background-image: url('../../content/icon/add.png');
                 background-repeat: no-repeat;
                 background-position: center;
                 padding-left: 16px;
                
        }
            .btnInsert-text{
               padding-right: 16px;
            } */

.main-content .content-input{
    height: 43px;
    width: 100%;
    display: flex;
    background-color: transparent;
    box-sizing: border-box;
    padding-top: 4px;
    padding-bottom: 10px;
}
.main-content .content-input .input-search:focus{
    border: 1px solid #2FBEBE;
}
.main-content .content-input .input-search:hover{
    border: 1px solid #2FBEBE;
}
    .main-content .content-input .input-search{
        width: 320px;
        height: 43px;
        display: flex;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left:10px ;
        flex-direction: row;
    }
       
        .main-content .content-input .input-search .btnSearch{
                    position: absolute;
                    border-radius: 50%;
                    border: 0;
                    background-color: transparent;
                    height: 43px;
                    width: 45px;
                    outline: 0;
                    background-image: url('../../content/icon/search.png');
                    background-repeat: no-repeat;
                    background-position: center; 
                    padding-left: 5px;
        }
        .main-content .content-input .input-search .btnSearch:hover{
           background-color: #d2d2d2;
           border-radius: 3px;
        }
        .main-content .content-input .input-search .search-box{
                    width: calc(320px - 45px);
                    position: absolute;
                    height: 43px;
                    left: 55px;
                    border: 0;
                    box-sizing: border-box;  
        }
         .main-content .content-input .input-search .search-box:focus{
             outline: 0;
         }


    .main-content .content-input .input-department{
        width: 200px;
        height: 43px;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left: 20px;
    }     
         .main-content .content-input .input-department select{
             box-sizing: border-box;
             height: 43px;
             width: 200px;
             border: 0;
         }


     .main-content .content-input .input-position{
        width: 200px;
        height: 43px;
        border: 1px solid #d2d2d2;
        border-radius: 3px;
        margin-left: 20px;
    }     
         .main-content .content-input .input-position select{
             box-sizing: border-box;
             height: 43px;
             width: 200px;
             border: 0;
         }


    .main-content .content-input .refresh-table  {
        height: 43px;
        width: 43px;
        box-sizing: border-box;
        background-image: url('../../content/icon/refresh.png');
        background-repeat: no-repeat;
        background-position: center; 
        position: absolute;
        right: 14px;
        border: 1px solid #d2d2d2;   
        border-radius: 2px; 
        cursor: pointer;
    }
    .main-content .content-input .refresh-table:hover{
        background-color: #2FBEBE;
        border: 0;
    }
 
        
            
</style>