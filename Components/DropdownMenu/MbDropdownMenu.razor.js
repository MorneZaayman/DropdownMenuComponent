export function initialize(id) {
    jQuery('#' + id + ' .list-group-item').on('click', function () {
        jQuery(this).find('.rotate-icon').toggleClass('rotated');
    });
}