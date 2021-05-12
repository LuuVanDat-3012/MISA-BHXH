<template>
  <div class="main-content">
    <div class="content-header">
      <div class="content-header-text">
        <h2>Danh sách khách hàng</h2>
      </div>
      <div class="content-header-button" @click="clickToShowDialog()">
        <button class="btnInsert">
          <img
            src="../../content/icon/add.png"
            alt=""
            width="20px"
            height="20px"
          />
          Thêm khách hàng
        </button>
      </div>
    </div>

    <div class="content-input">
      <div class="input-search">
        <div class="btnSearch">
          <div class="btnSearch"></div>
        </div>
        <div class="search-box">
          <input
            type="text"
            placeholder="Tìm kiếm theo tên, email... "
            class="text-input"
            @keyup.enter="findByCustomerCode()"
          />
        </div>
      </div>

      <MSCombobox v-bind:list="this.listDepartment"></MSCombobox>
      <MSCombobox v-bind:list="this.listPosition"> </MSCombobox>
      <div class="refresh-table"></div>
    </div>
    <CustomerTable></CustomerTable>
    <MSNavigation></MSNavigation>
  </div>
</template>
<script>
import MSCombobox from "../../content/combobox/combobox.vue";
import CustomerTable from "../../content/table/CustomerTable.vue";
import MSNavigation from "../../content/navigation/navigation.vue";

export default {
  name: "mscontent",
  components: {
    MSCombobox,
    CustomerTable,
    MSNavigation,
  },
  methods: {
    clickToShowDialog() {
      this.$emit("clickToShowDialog");
    },
  },
  data() {
    return {
      dialog: false,
      listDepartment: [
        "Tất cả phòng ban",
        "Phòng tài chính",
        "Phòng nhân sự",
        " Phòng kế toán",
      ],
      listPosition: [
        "Tất cả chức vụ",
        "Nhân viên kế toán",
        "Nhân viên kinh đoanh",
        "Bảo vệ",
      ],
    };
  },
};
</script>
<style scoped>
.main-content {
  padding: 16px 24px;
  height: calc(100% - 60px);
  box-sizing: border-box;
}
/*
  CSS phần header content
*/
.main-content .content-header {
  height: 48px;
  width: 100%;
  display: flex;
  box-sizing: border-box;
  align-items: center;
}
.main-content .content-header .content-header-text {
  position: absolute;
}
.main-content .content-header .content-header-button {
  position: absolute;
  right: 24px;
}
.btnInsert {
  background-color: #019160;
  height: 40px;
  color: #fff;
  border-radius: 4px;
  border: 0;
  align-content: center;
  display: flex;
  line-height: 40px;
  justify-content: center;
  align-items: center;
  padding: 12px;
}
.btnInsert img {
  padding-right: 6px;
}
.btnInsert:hover {
  background-color: #2fbebe;
  cursor: pointer;
}

/*
  CSS phần nhập liệu(content-input) và filter
*/
.main-content .content-input {
  height: 43px;
  width: 100%;
  display: flex;
  background-color: transparent;
  box-sizing: border-box;
}
.main-content .content-input .input-search input:focus {
  border: 1px solid #2fbebe;
}
.main-content .content-input .input-search:hover {
  border: 1px solid #2fbebe;
}
.main-content .content-input .input-search {
  width: 320px;
  height: 43px;
  display: flex;
  border: 1px solid #d2d2d2;
  border-radius: 4px;

  flex-direction: row;
  align-items: center;
  box-sizing: border-box;
}

.main-content .content-input .input-search .btnSearch {
  position: absolute;
  border-radius: 50%;
  border: 0;
  background-color: transparent;
  height: 43px;
  width: 45px;
  outline: 0;
  background-image: url("../../content/icon/search.png");
  background-repeat: no-repeat;
  background-position: center;
}

.main-content .content-input .input-search .search-box input {
  width: calc(320px - 48px);
  border: 0;
  box-sizing: border-box;
  height: 41px;
  margin-left: 45px;
  outline: 0;
}

/*
  CSS  Combobox
*/
.main-content .content-input .input-department {
  width: 200px;
  height: 43px;
  border: 1px solid #d2d2d2;
  border-radius: 3px;
  margin-left: 20px;
}
.main-content .content-input .input-department select {
  box-sizing: border-box;
  height: 43px;
  width: 200px;
  border: 0;
}

.main-content .content-input .input-position {
  width: 200px;
  height: 43px;
  border: 1px solid #d2d2d2;
  border-radius: 3px;
  margin-left: 20px;
}
.main-content .content-input .input-position select {
  box-sizing: border-box;
  height: 43px;
  width: 200px;
  border: 0;
}

/*t
    CSS button refresh table          
    */
.main-content .content-input .refresh-table {
  height: 43px;
  width: 43px;
  box-sizing: border-box;
  background-image: url("../../content/icon/refresh.png");
  background-repeat: no-repeat;
  background-position: center;
  position: absolute;
  right: 24px;
  border: 1px solid #d2d2d2;
  border-radius: 2px;
  cursor: pointer;
}
.main-content .content-input .refresh-table:hover {
  background-color: #2fbebe;
  border: 0;
}
</style>
