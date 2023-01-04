// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    var arrLang = {

        'tr': {

            '0': 'Dil Seçiniz',
            '1': 'Kullanıcılar',
            '2': 'Takımlar',
            '3': 'Futbolcular',
            '4': 'Teknik Direktörler',
            '5': 'Çıkış',
            '6': 'İngilizce',
            '7': 'Türkçe',
            '8': 'Adı',
            '9': 'Soyadı',
            '10': 'Yaş',
            '11': 'Takımı',
            '12': 'Maaş',
            '14': 'Teknik Direktor Ekle',
            '15': 'Güncelle',
            '16': 'Sil',
            '17': 'Ekle',
            '18': 'Teknik Direktör Güncelle',
            '19': 'Mevki',
            '20': 'Futbolcu Ekle',
            '21': 'Futbolcu Güncelle',
            '22': 'Şampiyonluk',
            '23': 'Kuruluş Tarihi',
            '24': 'Değer',
            '25': 'Durum',
            '26': 'Takım Ekle',
            '27': 'Takım Güncelle',
            '28': 'Kullanıcı Ekle',
            '29': 'Kullanıcı Güncelle',
            '30': 'Mail',
            '31': 'Şifre',
            '32': 'Rol',


        },

        'en': {
            '0': 'Select Language',
            '1': 'Users',
            '2': 'Teams',
            '3': 'Players',
            '4': 'Technical Directors',
            '5': 'Log Out',
            '6': 'English',
            '7': 'Turkish',
            '8': 'Name',
            '9': 'Surname',
            '10': 'Age',
            '11': 'Team',
            '12': 'Salary',
            '14': 'Add Technical Director',
            '15': 'Update',
            '16': 'Delete',
            '17': 'Add',
            '18': 'Update Technical Director',
            '19': 'Position',
            '20': 'Add Player',
            '21': 'Update Player',
            '22': 'Championship ',
            '23': 'Establishment Date',
            '24': 'Total Value',
            '25': 'State',
            '26': 'Add Team',
            '27': 'Update Team',
            '28': 'Add User',
            '29': 'Update User',
            '30': 'Mail',
            '31': 'Password',
            '32': 'Status',
        },


    };



    $('.dropdown-item').click(function () {
        localStorage.setItem('dil', JSON.stringify($(this).attr('id')));
        location.reload();
    });

    var lang = JSON.parse(localStorage.getItem('dil'));

    if (lang == "en") {
        $("#drop_yazı").html("English");
    }
    else {
        $("#drop_yazı").html("Türkçe");

    }

    $('a,h5,p,h1,h2,span,li,button,h3,label').each(function (index, element) {
        $(this).text(arrLang[lang][$(this).attr('key')]);

    });

});