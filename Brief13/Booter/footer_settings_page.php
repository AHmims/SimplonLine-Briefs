<?php
global $chk;
if (isset($_POST['wphw_submit'])) {
    wphw_opt();
}
function wphw_opt()
{
    $foterText = $_POST['footertextname'];
    $fbText = $_POST['facebookURL'];
    $twtText = $_POST['twitterURL'];
    // 
    // 
    global $chk, $fbURI, $twtURI;
    if (get_option('footer_text') != trim($foterText))
        $chk = update_option('footer_text', trim($foterText));
    if (get_option('facebook_URL') != trim($fbText))
        $fbText = update_option('facebook_URL', trim($fbText));
    if (get_option('twitter_URL') != trim($twtText))
        $twtText = update_option('twitter_URL', trim($twtText));
}
?>
<div class="wrap">
    <div id="icon-options-general" class="icon32"> <br>
    </div>
    <h2>Footer Settings</h2>
    <?php if (isset($_POST['wphw_submit'])) : ?>
        <div id="message" class="updated below-h2">
            <p>Content updated successfully</p>
        </div>
    <?php endif; ?>
    <div class="metabox-holder">
        <div class="postbox">
            <h3><strong>Enter footer text and click on save button.</strong></h3>
            <h3>
                <form method="post" action="">
                    <table class="form-table">
                        <tr>
                            <th scope="row">Footer Text</th>
                            <td><input type="text" name="footertextname" value="<?php echo get_option('footer_text'); ?>" style="width:350px;" /></td>
                        </tr>
                        <tr>
                            <th scope="row">Facebook URL</th>
                            <td><input type="text" name="facebookURL" value="<?php echo get_option('facebook_URL'); ?>" style="width:350px;" /></td>
                        </tr>
                        <tr>
                            <th scope="row">Twitter URL</th>
                            <td><input type="text" name="twitterURL" value="<?php echo get_option('twitter_URL'); ?>" style="width:350px;" /></td>
                        </tr>
                        <tr>
                            <th scope="row">&nbsp;</th>
                            <td style="padding-top:10px;  padding-bottom:10px;">
                                <input type="submit" name="wphw_submit" value="Save changes" class="button-primary" />
                            </td>
                        </tr>
                    </table>
                </form>
            </h3>
        </div>
    </div>
</div>