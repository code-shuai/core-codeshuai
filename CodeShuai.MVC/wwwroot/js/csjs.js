

Vue.component('cs-foot', {
    props: ['post'],
    template: 
        `
        <div>
            
        </div>
        `,
    computed: {
        width: function () {
            var ew = window.screen.width;

        }
    }
})



Vue.component('cs-bill', {
    data: function () {
        return {

        }
    },
    props: ['post'],
    template: `
        <div>
            <span class=""><i v-bind:class="post.lableCode" v-bind:style="divWidth"></i></span>
            <a class="csbill-remark">{{post.remark==""||post.remark==null?post.lableName:post.remark}}</a>
            <a class="csbill-money">{{post.money}}</a>
            <hr />
        </div>

	`,
    computed: {
        divWidth: function () {
            var ew = window.screen.width;
            ew=="" ?1:0
            return 'font-size:' + ((ew / 12) * (3 / 4)).toFixed(2) + 'px';
        }
    }

})













//var a = $("#sjnavHead").height(),//width()返回元素的宽高，不包括padding/border/margin
//    b = $("#sjnavHead").innerHeight(),//innerWidth()返回元素的宽高 + padding
//    c = $("#sjnavHead").outerHeight(),//outerWidth()返回元素的宽高 + padding + border
//    d = $("#sjnavHead").outerHeight(true);//outerWidth(true)返回元素宽高 + padding + border + margin
//var wname = window.navigator.userAgent;
//var screen_width = window.screen.width;
//var screen_height = window.screen.height;
//var w = $(document).width();
//var h = $(document).height();
//console.log(a + ',' + b + ',' + c + ',' + d);
//console.log(wname);
//console.log("width:" + screen_width + "--height:" + screen_height + "--otherWidth:" + w + "--otherHeight" + h);
//console.log(sjnavHeight);
